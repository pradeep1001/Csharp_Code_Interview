using system;
using system.collections.generic;
using system.text;

namespace pradeep_1
{
    class program6
    {
        static void main(string[] args)
        {
            int n = 9;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    console.write(j);
                    if (j == 2 * i - 1 && j > 1)
                    {
                        for (int k = j - 1; k >= i; k--)
                        {
                            console.write(k);
                        }
                    }
                }
                console.writeline("");
            }
        }
    }

}
