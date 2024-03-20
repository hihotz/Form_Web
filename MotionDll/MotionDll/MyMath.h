#include "pch.h"
#pragma once

#ifdef CREATEDLL_EXPORTS
#define MYMATH_DECLSPEC __declspec(dllexport)
#else
#define MYMATH_DECLSPEC __declspec(dllimport)
#endif

extern "C" MYMATH_DECLSPEC int SUM(int a, int b);
extern "C" MYMATH_DECLSPEC int Sub(int a, int b);
extern "C" MYMATH_DECLSPEC int Mul(int a, int b);
extern "C" MYMATH_DECLSPEC int Div(int a, int b);