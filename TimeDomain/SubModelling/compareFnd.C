// SPDX-FileCopyrightText: 2023 SAP SE
//
// SPDX-License-Identifier: Apache-2.0
//
// This file is part of FEDEM - https://openfedem.org
////////////////////////////////////////////////////////////////////////////////

/*!
  \file compareFnd.C
  \brief This program reads two Fnd-files and checks if they are equal or not.
*/

#include "FFaLib/FFaOS/FFaTag.H"
#include <iostream>
#include <iomanip>
#include <vector>
#include <cmath>


int main (int argc, char** argv)
{
  if (argc < 3)
  {
    std::cout <<"usage: "<< argv[0] <<" [<tol>] <file1> <file2>"<< std::endl;
    return 99;
  }

  const double ctol = argc > 3 ? atof(argv[1]) : 1.0e-16;
  const char* file1 = argv[argc > 3 ? 2 : 1];
  const char* file2 = argv[argc > 3 ? 3 : 2];

  FT_FILE f1 = FT_open(file1,FT_rb);
  if (f1 <= (FT_FILE)0)
  {
    perror(file1);
    return 1;
  }

  FT_FILE f2 = FT_open(file2,FT_rb);
  if (f2 <= (FT_FILE)0)
  {
    perror(file2);
    return 2;
  }

  // Lambda function for reading the file header.
  auto&& readHeader = [](FT_FILE fDes, int& nnod, int& nndof)
  {
    // Read file header and check that it is the right file
    std::string myTag;
    unsigned int myCS;
    nnod = FFaTag::read(fDes,myTag,myCS,LEN_TAG);
    if (nnod != FFaTag::endian() || myTag.find("#FEDEM nodal displacements"))
    {
      std::cerr <<" *** Invalid displacement file, tag = "<< myTag << std::endl;
      return false;
    }

    char buf[16];
    if (!FT_gets(buf,16,fDes))
    {
      std::cerr <<" *** Error reading file version number"<< std::endl;
      return false;
    }

    float currVer, dummy;
    if (sscanf(buf,";%f;%d;",&currVer,&nnod) < 2)
    {
      std::cerr <<" *** Erroneous file version field: "<< buf << std::endl;
      return false;
    }
    else if (currVer < 7.3)
    {
      std::cerr <<" *** Wrong file version: "<< currVer << std::endl;
      return false;
    }

    nndof = 10.0f*modff(currVer,&dummy) + 0.5f;
    return true;
  };

  int nnod1, nnod2, nndof1, nndof2;
  if (!readHeader(f1,nnod1,nndof1) || !readHeader(f2,nnod2,nndof2))
    return 3;
  else if (nnod1 != nnod2 || nndof1 != nndof2)
  {
    std::cout <<"   * Files have different size, nnod = "<< nnod1 <<" "<< nnod2
              <<" nndof = "<< nndof1 <<" "<< nndof2 << std::endl;
    return 11;
  }

  size_t nr, n = nnod1;
  std::cout <<"   * Number of nodes = "<< n <<", nCmp = "<< nndof1 << std::endl;

  std::vector<int> nodes1(n), nodes2(n);
  if ((nr = FT_read(nodes1.data(),sizeof(int),n,f1)) < n)
  {
    std::cerr <<" *** Failure reading nodes from "<< file1
              <<": "<< nr <<" < "<< n << std::endl;
    return 4;
  }
  if ((nr = FT_read(nodes2.data(),sizeof(int),n,f2)) < n)
  {
    std::cerr <<" *** Failure reading nodes from "<< file2
              <<": "<< nr <<" < "<< n << std::endl;
    return 5;
  }
  if (nodes1 != nodes2)
  {
    std::cout <<"   * Nodal mismatch."<< std::endl;
    return 12;
  }

  int ndiff = 0;
  std::vector<double> v1(1+n*nndof1), v2(1+n*nndof2);
  while (true)
  {
    int i1, i2, last = ndiff;
    if ((nr = FT_read(&i1,sizeof(int),1,f1)) != FT_read(&i2,sizeof(int),1,f2))
    {
      std::cout <<"   * File length mismatch."<< std::endl;
      return 13;
    }
    else if (nr < 1)
      break; // end-of-file reached
    else if (i1 != i2)
    {
      std::cout <<"   * File step mismatch, "<< i1 <<" != "<< i2 << std::endl;
      ndiff++;
    }

    if ((nr = FT_read(v1.data(),sizeof(double),v1.size(),f1)) < v1.size())
    {
      std::cerr <<" *** Failure reading data from "<< file1 << std::endl;
      return 6;
    }

    if ((nr = FT_read(v2.data(),sizeof(double),v2.size(),f2)) < v2.size())
    {
      std::cerr <<" *** Failure reading data from "<< file2 << std::endl;
      return 7;
    }

    for (size_t i = 0; i < v1.size(); i++)
    {
      double diff = fabs(v1[i] - v2[i]);
      if (diff > ctol && diff > ctol*0.5*(fabs(v1[i])+fabs(v2[i])))
      {
        std::cout <<"   * Data mismatch, at t = "<< v1.front()
                  <<",  i ="<< std::setw(6) << i <<": ";
        std::streamsize oldPrec = std::cout.precision(10);
        std::ios::fmtflags oldF = std::cout.flags(std::ios::scientific);
        std::cout << v1[i] <<" "<< v2[i];
        std::cout.precision(4);
        std::cout <<",  diff = "<< diff << std::endl;
        std::cout.precision(oldPrec);
        std::cout.flags(oldF);
        ndiff++;
      }
    }
    if (ndiff == last)
      std::cout <<"   * Step "<< i1 <<" t = "<< v1.front() <<" OK"<< std::endl;
  }

  if (ndiff == 0)
    std::cout <<"   * The files "<< file1 <<" and "<< file2
              <<" are identical."<< std::endl;

  FT_close(f1);
  FT_close(f2);
  return ndiff;
}
