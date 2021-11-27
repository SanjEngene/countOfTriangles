using System;

namespace countOfTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = Convert.ToInt32(Console.ReadLine());
            int countOfTriangles = 0;
            int byOne = 1;
            int counter = 1;
            while (byOne != floor + 1)
            {
                if (byOne == 1)
                {
                    for (int i = 0; i < (floor - byOne) + 1; i++)
                    {    
                        countOfTriangles += counter;
                        counter += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < (floor - byOne) + 1; i++)
                    {
                        if (i == 0)
                        {
                            countOfTriangles += counter;
                        }
                        else if (i == 1)
                        {
                            counter++;
                            countOfTriangles += counter;
                        }
                        else
                        {
                            counter += 2;
                            countOfTriangles += counter;
                        }
                    }
                }
                byOne++;
                counter = 1;
            }

            Console.WriteLine(countOfTriangles);
        }
    }
}
