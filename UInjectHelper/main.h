#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
// Windows Header Files
#include <iostream>
#include <fstream>
#include <Windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <vector>
#include <string>
#include <Psapi.h>
#include <msclr\marshal.h>
#include <msclr\marshal_cppstd.h>

using namespace std;
using namespace System::Reflection;

#include "MonoUtils.h"
#include "MonoProcess.h"