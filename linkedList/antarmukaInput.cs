using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class Interface
    {
        public LList p = new LList();

        int Length, Fill, NotFill, Start, Avail;

        public void MainMenu()
        {
            byte pil;
            bool x = true;
           
            while (x == true)
            {
                Console.Clear();
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 1.5 + "}", "Kelompok Linked List 2IA03"));
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("");
                p.ShowTable();
                Console.WriteLine("");
                p.ShowLlist(p.Start, "Start");
                p.ShowLlist(p.Avail, "Avail");
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Input Linked List\n2. Insert Linked List Dari Depan\n3. Insert Linked List Dari Tengah\n4. Keluar dari Program\n5. Delete");
                Console.Write("Masukkan Pilihan :");
                pil = Convert.ToByte(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Reset();
                        break;
                    case 2:
                        Insfirst();
                        break;
                    case 3:
                        Insloc();
                        break;
                    case 4:
                        x = false;
                        break;
                    case 5:
                        Delete();
                        break;

                    default:
                        Console.WriteLine("Masukan Pilihan!");
                        Console.ReadKey();
                        break;
                }
                
            }
        }

        void Reset()
        {
            

            Console.WriteLine("Masukkan Linked List");

            Console.Write("Panjang Linked List:");
            Length = Convert.ToInt16(Console.ReadLine());

            Console.Write("Banyak Linked list yang ingin diisi : ");
            Fill = Convert.ToInt16(Console.ReadLine());
            NotFill = Length - Fill;

            Console.Write("Start : ");
            Start = Convert.ToInt16(Console.ReadLine());

            Console.Write("Avail : ");
            Avail = Convert.ToInt16(Console.ReadLine());

            p = new LList(Length, Start, Avail);

            

            Console.WriteLine("===========================================");
            Console.WriteLine("LINK");
            p.Setup(Fill, Start, false);
            Console.WriteLine("AVAIL");
            p.Setup(NotFill, Avail, true);
        }

        void Insfirst()
        {
            int Item;
            Console.WriteLine("Input Dari Awal");
            Console.Write("Item baru :");
            Item = Convert.ToInt16(Console.ReadLine());
            p.InsFirst(Item);
        }

        void Insloc()
        {
            int Item, Loc;
            Console.WriteLine("Input Dari Tengah");
            Console.Write("Item baru :");
            Item = Convert.ToInt16(Console.ReadLine());
            Console.Write("Lokasi :");
            Loc = Convert.ToInt16(Console.ReadLine());
            p.InsLoc(Item, Loc);
        }
        void Delete()
        {
            int Item;
            Console.WriteLine("Delete Linked List");
            Console.WriteLine("Link");
            Item = Convert.ToInt16(Console.ReadLine());
            p.Delete(Item);
        }
            
    }
}