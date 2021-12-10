using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Week_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pilihMenu = 0;
            var counter = 0;
            var add = 0;
            var posisi = 0;

            List<string> scrollBaru = new List<string>();
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };

            while (true)
            {
                Console.WriteLine("1. My scroll list \n2. Add scroll \n3. Search Scroll \n4. Remove scroll");
                Console.WriteLine("Choose what to do : ");
                pilihMenu = Convert.ToInt32(Console.ReadLine());

                if (pilihMenu == 1)
                {
                    counter = 0;
                    Console.Clear();
                    Console.WriteLine("Scroll to learn list :");
                    foreach (var scroll in scrolls)
                    {
                        counter++;
                        Console.WriteLine($"Scroll {counter} : {scroll}");
                    }
                }
                else if (pilihMenu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many scroll to add : ");
                    add = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue ? ");
                    posisi = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < add; i++)
                    {
                        Console.Write("Scroll " + (i + 1) + " Name : ");
                        scrollBaru.Add(Console.ReadLine());
                    }
                    if (posisi < 1)
                    {
                        posisi = 0;
                    }
                    else if (posisi > scrolls.Count())
                    {
                        posisi = scrolls.Count();
                    }
                    counter = 0;
                    foreach (var scroll in scrollBaru)
                    {
                        scrolls.Insert(posisi + counter, scroll);
                        counter++;
                    }
                    scrollBaru.Clear();
                }
                else if (pilihMenu == 3)
                {
                    Console.WriteLine("Insert scroll name : ");
                    string cariScroll = Console.ReadLine();
                    if (scrolls.FindIndex(b => b.Equals(cariScroll, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        var data = scrolls.FindIndex(b => b.Equals(cariScroll, StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine($"Book found. Queue number {data + 1}");
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    } 
                }
                else if (pilihMenu == 4)
                {
                    Console.WriteLine("Remove from list by sroll name? (y/n)");
                    string input = Console.ReadLine();
                    while (input != "y" && input != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again : ");
                        input = Console.ReadLine();
                    }
                    if (input == "y")
                    {
                        Console.WriteLine("Input scroll name : ");
                        string scrollRemove = Console.ReadLine();
                        for (int i = 0; i < scrolls.Count; i++)
                        {
                            if (scrolls.FindIndex(b => b.Equals(scrollRemove, StringComparison.OrdinalIgnoreCase)) != -1)
                            {
                                var hapus = scrolls.FindIndex(b => b.Equals(scrollRemove, StringComparison.OrdinalIgnoreCase));
                                scrolls.RemoveAt(i);
                                Console.WriteLine("Book removed!");
                            }
                        }
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Input scroll queue : ");
                        int queue = Convert.ToInt32(Console.ReadLine());
                        int uji = 1;
                        while (uji == 1)
                        {
                            for (int i = 1; i <= scrolls.Count; i++)
                            {
                                if (queue == i)
                                {
                                    scrolls.Remove(scrolls[i - 1]);
                                    Console.WriteLine("Book removed!");
                                    uji = 0;
                                } 
                            }
                            if (uji == 1)
                            {
                                Console.WriteLine("Queue not found. Insert scroll queue : ");
                                queue = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }

                }
            }
        }
    }
}
