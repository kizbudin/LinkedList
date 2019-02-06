using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class LList
    {
        
        public int[] Info;
        public int[] Link;
        public bool[] Flag;
        public int Start, Avail;

        
        public LList()
        {

        }

        
        public LList(int Length, int iStart, int iAvail)
        {
            Info = new int[Length];
            Link = new int[Length];
            Flag = new bool[Length];
            Start = iStart;
            Avail = iAvail;
        }


        
        public void Setup(int Fill, int Mulai, bool Mode)
        {
            int Ptr, Count;
            Ptr = Mulai - 1; 
            Count = 1; 

            while (Count <= Fill)
            {
                Flag[Ptr] = true; 

                if (Mode == false)
                { 
                    Console.Write("Info[{0}] :", Ptr + 1);
                    Info[Ptr] = Convert.ToInt16(Console.ReadLine());
                }

                if (Count != Fill) 
                {
                    Console.Write("Link[{0}] :", Ptr + 1);
                    Link[Ptr] = Convert.ToInt16(Console.ReadLine());
                    while (Flag[Link[Ptr] - 1] == true) 
                    {
                        Console.WriteLine("Sudah Terisi!");
                        Console.Write("Link[{0}] :", Ptr + 1);
                        Link[Ptr] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                else 
                {
                    Link[Ptr] = 0;
                }
                Ptr = Link[Ptr] - 1;
                Console.WriteLine("--------------------------");
                Count++;
            }
            return;
        }

        public void InsFirst(int Item)
        {
            int New;
            if (Avail == 0) Console.WriteLine("Overflow!");
            New = Avail;
            Avail = Link[Avail - 1];
            Info[New - 1] = Item;
            Link[New - 1] = Start;
            Start = New;
        }

        public void Delete(int Item)
        {
            int Del;
            if (Avail < 0) Console.Write("Underflow!");
            Del = Item;
            Item = Link[Item = 0];
            Info[Del = 0] = Item;
            Start = Del;
        }

        public void InsLoc(int Item, int Loc)
        {
            int New;
            if (Avail == 0) Console.WriteLine("Overflow!");
            else
            {
                New = Avail;
                Avail = Link[Avail - 1];
                Info[New - 1] = Item;
                if (Loc == 0)
                {
                    Link[New - 1] = Start;
                    Start = New;
                }
                else
                {
                    Link[New - 1] = Link[Loc - 1];
                    Link[Loc - 1] = New;
                }
            }
        }

        public void ShowTable()
        {
            int iStart = Start - 1;
            int iAvail = Avail - 1;
            if (Start == 0)
            {
                Console.WriteLine("Output Tabel Linked List: ");
                Console.WriteLine("");
                Console.WriteLine("\t| Info \t| Link\t |");
                Console.WriteLine("\t|--Null--|--Null--|");
                Console.WriteLine("\t|--Null--|--Null--|");
                Console.WriteLine("\t|--Null--|--Null--|");
                Console.WriteLine("\t|--Null--|--Null--|");
            }
            else
            {
                Console.WriteLine("\t\t| Info\t| Link\t|");
                Console.WriteLine("\t\t|-------|-------|");
                for (int i = 0; i < Info.Length; i++)
                {
                    if (Flag[i] == false)
                    {
                        Console.WriteLine("[{0}]\t\t| Null\t| Null\t|", i + 1);
                    }
                    else if (i == iStart)
                    {
                        Console.WriteLine("[{0}]Start==>\t| {1}\t| {2}\t|", i + 1, Info[i], Link[i]);
                    }
                    else if (i == iAvail)
                    {
                        Console.WriteLine("[{0}]Avail-->\t| {1}\t| {2}\t|", i + 1, Info[i], Link[i]);
                    }
                    else Console.WriteLine("[{0}]\t\t| {1}\t| {2}\t|", i + 1, Info[i], Link[i]);

                }
                Console.WriteLine();
            }
        }


        public void ShowLlist(int Mulai, string Label)
        {
            if (Mulai == 0)
            {
                Console.WriteLine("{0} :NULL", Label);
            }
            else
            {
                int Ptr;
                Ptr = Mulai - 1;
                Console.Write("{0} :", Label);
                Console.Write("[{0}", Mulai);
                while (Ptr != -1)
                {
                    Console.Write("]-[{0}|{1}", Info[Ptr], Link[Ptr]);
                    Ptr = Link[Ptr] - 1;
                }
                Console.WriteLine("]");
            }
        }
    }
}