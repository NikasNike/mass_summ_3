using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    
    static void tets()
    {
        int res = 27;
        int res1 = 18;
        int helping = 0;
        int number = 3;
        int[] mass = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,10,10 };

        int[] massHelp = new int[3];
        helping = res;
        for(int i = 0; i < mass.Length; i++)
        {
            if (mass[i] != res)
            {
                helping = res - mass[i];
                massHelp[0] = mass[i];
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[j] != res && mass[j] - helping != 0 && j != i)
                    {

                        helping = res - mass[i] - mass[j];
                        massHelp[1] = mass[j];
                        for (int k = 0; k < mass.Length; k++)
                        {
                            if (k != j && k != i &&  helping - mass[k] == 0)
                            {
                                helping =res -  mass[i] - mass[j] - helping;
                                massHelp[2] = mass[k];
                                Console.WriteLine("ответ:  " + res + " = " + massHelp[0] + " + " + massHelp[1] + " + " + massHelp[2]);
                                number = 0;
                            }

                        }
                    }
                }
            }
        }
        if (number != 0)
        {
            Console.WriteLine("нет ответа");
        }
    }
    



    static void Main(string[] args)
    {
        tets();
    }
}