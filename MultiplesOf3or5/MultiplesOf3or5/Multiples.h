#include<iostream>
using namespace std;

class Multiples
{
	public:
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
};