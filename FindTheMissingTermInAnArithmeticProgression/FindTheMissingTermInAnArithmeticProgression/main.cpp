#include<iostream>
#include<vector>
#include"FindMissing.h"
using namespace std;


int main()
{
	FindMissing f;
	vector<long> v = { 1, 2, 3, 5 };
	cout << f.findMissing(v) << endl;
	system("PAUSE");
	return 0;
}