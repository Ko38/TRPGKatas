#include "stdafx.h"
#include "CppUnitTest.h"
#include"../FindTheMissingTermInAnArithmeticProgression/FindMissing.h"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	private:
		FindMissing * f;
	public:
		UnitTest1()
		{
			f = new FindMissing();
		}
		TEST_METHOD(TestMethod1)
		{
			Assert::AreEqual((long)7, f->findMissing({ 1, 3, 5, 9, 11 }));
		}
		TEST_METHOD(TestMethod2)
		{
			Assert::AreEqual((long)15, f->findMissing({ 0, 5, 10, 20, 25 }));
		}
		TEST_METHOD(TestMethod3)
		{
			Assert::AreEqual((long)10, f->findMissing({ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }));
		}
		TEST_METHOD(TestMethod4)
		{
			Assert::AreEqual((long)1400, f->findMissing({ 1040, 1220, 1580 }));
		}
		~UnitTest1()
		{
			delete f;
		}
	};
}