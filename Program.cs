//*****************************************************************************
//** 3714. Longest Balanced Substring II                            leetcode **
//*****************************************************************************
//** Three letters walk a string in quiet stride,
//** We count their steps and track them side by side;
//** When equal beats among the seen appear,
//** The longest balanced stretch grows crystal clear.
//*****************************************************************************

int longestBalanced(char *s)
{
    int n = strlen(s);
    int res = 1; 

    for (int i = 0; i < n; i++)
    {
        int cnt[3] = {0, 0, 0};

        for (int j = i; j < n; j++)
        {
            cnt[s[j] - 'a']++;

            int distinct = 0;
            int min = 100001;
            int max = 0;

            for (int k = 0; k < 3; k++)
            {
                if (cnt[k] > 0)
                {
                    distinct++;
                    if (cnt[k] < min) min = cnt[k];
                    if (cnt[k] > max) max = cnt[k];
                }
            }

            if (distinct == 1)
            {
                if (j - i + 1 > res)
                    res = j - i + 1;
            }
            else if (min == max)
            {
                if (j - i + 1 > res)
                    res = j - i + 1;
            }
        }
    }

    return res;
}