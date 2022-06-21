#define MyFunctions _declspec(dllexport)
#include "stdint.h"
#include <string>

extern "C" {
	MyFunctions uint8_t is_palindrome(char *input)
	{
		std::string str(input);
		std::string reversed(str.rbegin(), str.rend());
		return !str.compare(reversed);
	}
}