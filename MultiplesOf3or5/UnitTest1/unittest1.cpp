#include "stdafx.h"
#include "CppUnitTest.h"
#include "../MultiplesOf3or5/Multiples.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{	
	TEST_CLASS(UnitTest1)
	{
		public:
			TEST_METHOD(TestMethod1)
			{
				Multiples * m = new Multiples();
				Assert::AreEqual(23, m->solution(10));
				delete m;
			}
	
	};
}