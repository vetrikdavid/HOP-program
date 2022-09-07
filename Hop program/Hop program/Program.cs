using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hop_program
{
    class Program
    {
        static void Main(string[] args)
        {
            textDataRead();
            Console.ReadKey();
        }

        public static void textDataRead()
        {
            try
            {
                StreamReader reader = new StreamReader("feladat2.txt");
                string instructionselect = "", readline = "";
                int finalnum = 0, jump = 0;
                List<string> orders = new List<string>();
                List<string> nextOrder = new List<string>();
                List<int> prevorder = new List<int>();

                while ((readline = reader.ReadLine()) != null)
                {
                    orders.Add(readline);
                }
                int i = 0;
                for(i=0;i<orders.Count;i++)
                {
                    foreach (var items in prevorder)
                    {
                        if (i == items)
                        {
                            Console.WriteLine("Ebben a sorban már jártunk, indexe: " + i);
                            Console.WriteLine("Belső változó értéke: " + finalnum);
                            Console.ReadKey();
                        }
                    }
                    //Console.WriteLine(orders[i]);
                    nextOrder = orders[i].Split(' ').ToList();
                    instructionselect = nextOrder[0];
                    switch (instructionselect)
                    {
                        case "acc":
                            finalnum += int.Parse(nextOrder[1]);
                            break;

                        case "nop":

                            break;

                        case "jmp":
                            jump = int.Parse(nextOrder[1]);
                            i = i + jump;
                            break;
                    }
                    prevorder.Add(i);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Hiba: " + err.Message);
            }
        }



    }
}
