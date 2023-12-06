// SPDX-FileCopyrightText: 2023 SAP SE
//
// SPDX-License-Identifier: Apache-2.0
//
// This file is part of FEDEM - https://openfedem.org
////////////////////////////////////////////////////////////////////////////////

/*!
  \file listFnd.C
  \brief This program reads a Fnd-file and prints its content to console.
*/

#include "FFaLib/FFaOS/FFaTag.H"
#include <iostream>
#include <iomanip>
#include <vector>
#include <cmath>


int main (int argc, char** argv)
{
  if (argc < 2)
  {
    std::cout <<"usage: "<< argv[0] <<" <fileName>"<< std::endl;
    return 99;
  }

  const char* fileName = argv[1];
  FT_FILE fd = FT_open(fileName,FT_rb);
  if (fd <= (FT_FILE)0)
  {
    perror(fileName);
    return 1;
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

    nndof = 10.0f*modff(currVer,&dummy) + 0.5;
    return true;
  };

  int nnod, nndof;
  if (readHeader(fd,nnod,nndof))
    std::cout <<"   * Number of nodes = "<< nnod <<", nCmp = "<< nndof;
  else
    return 2;

  size_t i, nr, n = nnod;
  std::vector<int> nodes(n);
  if ((nr = FT_read(nodes.data(),sizeof(int),n,fd)) < n)
  {
    std::cerr <<" *** Failure reading nodes from "<< fileName
              <<": "<< nr <<" < "<< n << std::endl;
    return 3;
  }

  for (i = 0; i < n; i++)
    std::cout << (i%10 ? " " : "\n     ") << nodes[i];
  std::cout << std::endl;

  int istep = 0;
  std::vector<double> v(1+nnod*nndof);
  while ((nr = FT_read(&istep,sizeof(int),1,fd)) == 1)
  {
    if ((nr = FT_read(v.data(),sizeof(double),v.size(),fd)) < v.size())
    {
      std::cerr <<" *** Failure reading data from "<< fileName
                <<" (step "<< istep <<")"<< std::endl;
      return 4;
    }

    std::cout <<"\n   * Step "<< istep <<" t = "<< v.front();
    std::streamsize oldPrec = std::cout.precision(10);
    std::ios::fmtflags oldF = std::cout.flags(std::ios::scientific);
    for (i = 1; i < v.size(); i++)
      std::cout << (i%nndof == 1 ? "\n     " : " ") << v[i];
    std::cout << std::endl;
    std::cout.precision(oldPrec);
    std::cout.flags(oldF);
  }

  FT_close(fd);
  return 0;
}
