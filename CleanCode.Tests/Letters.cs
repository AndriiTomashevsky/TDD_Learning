using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Tests
{
    public static class Letter
    {
        public static string X()
        {
            string letter = null;

            letter += "\n";

            for (int k = 1; k < 3; k++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        if ((k == 1 && (i == j || i == (9 - j))) || (k == 2 && (i == (5 - j) || i == (4 + j))))
                        {
                            letter += "@";
                        }
                        else
                        {
                            letter += "x";
                        }
                    }

                    letter += "\n";
                }
            }

            return letter;
        }

        public static string X2()
        {
            string letter = null;

            letter += "\n";

            int i = 8, j = 4;


            while (j != 0)
            {
                while (i != 0)
                {
                    if (i == 1 || i == 8)
                    {
                        letter += "@";

                    }
                    else
                    {
                        letter += "x";
                    }

                    i--;
                }

                i = 8;
            }

            while (i != 0)
            {
                if (i == 1 || i == 8)
                {
                    letter += "@";

                }
                else
                {
                    letter += "x";
                }

                i--;
            }

            letter += "\n";

            i = 8;

            while (i != 0)
            {
                if (i == 2 || i == 7)
                {
                    letter += "@";

                }
                else
                {
                    letter += "x";
                }

                i--;
            }

            letter += "\n";

            i = 8;

            while (i != 0)
            {
                if (i == 3 || i == 6)
                {
                    letter += "@";

                }
                else
                {
                    letter += "x";
                }

                i--;
            }

            letter += "\n";



            return letter;
        }
    }
}
