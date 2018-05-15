#include "stdafx.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	int solution(int number)
	{
		int result = 0;
		for (int n = 0; n < number; n++)
		{
			if (n % 3 == 0 || n % 5 == 0)
			{
				result += n;
			}
		}
		return result;
	}
	

	TEST_CLASS(UnitTest1)
	{
		public:
			TEST_METHOD(TestMethod1)
			{
				Assert::AreEqual(23, solution(10));
			}
	
	};
}