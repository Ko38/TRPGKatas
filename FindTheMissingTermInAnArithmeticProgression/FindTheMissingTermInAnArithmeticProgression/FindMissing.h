#include<iostream>
#include<vector>
using namespace std;

class FindMissing
{
private:
	vector<long> findProgressionCandidates(vector<long> list)
	{
		vector<long> candidates;
		candidates.push_back(list.at(1) - list.at(0));
		candidates.push_back(list.at(2) - list.at(1));
		return candidates;
	}
public:
	long findMissing(vector<long> list)
	{
		vector<long> candidates = findProgressionCandidates(list);
		for (auto j = 0; j < candidates.size(); j++)
		{
			for (auto i = 0; i < list.size(); i++)
			{
				if (list.at(i) + candidates.at(j) != list.at(i + 1))
				{
					if (list.at(i) + candidates.at(j) < list.back())
					{
						return list.at(i) + candidates.at(j);
					}
				}
			}
		}
		
		return list[0];
	}
};