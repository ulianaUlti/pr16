using System;
using System.Collections;

namespace PRACT16_4
{
    class Program
    { 
            static void PrintAllCatalog(Hashtable ht)
            {              
                ICollection key = ht.Keys;
                foreach (string i in key)
                {
                    Console.WriteLine(i + "\t" + ht[i]);
                }
            }
            static void Main(string[] args)
            {

                Hashtable disc = new Hashtable();
                Hashtable songs = new Hashtable();

            

                disc.Add("01", "K-POP");
                disc.Add("02", "Mitasgi");
                disc.Add("03", "DELETED");
                disc.Add("04", "Fantast");
                disc.Add("05", "Hihgtcore");
                disc.Add("06", "Pan");
                songs.Add("0101", "AAA"); songs.Add("0102", "BBB"); songs.Add("0103", "CCC");
                songs.Add("0201", "DDD"); songs.Add("0202", "EEE"); songs.Add("0203", "FFF");
                songs.Add("0301", "GGG"); songs.Add("0302", "HHH"); songs.Add("0303", "III");
                songs.Add("0401", "JJJ"); songs.Add("0402", "KKK"); songs.Add("0403", "LLL");
                songs.Add("0501", "MMM"); songs.Add("0502", "NNN"); songs.Add("0503", "OOO");
                songs.Add("0601", "PPP"); songs.Add("0602", "QQQ"); songs.Add("0603", "RRR");



                Console.WriteLine("Введите название нового диска");
                string newDiscName = Console.ReadLine();

                ICollection keyD = disc.Keys;
                string del = "DELETED";
                int result;
                foreach (string i in keyD)
                {
                    result = string.Compare(disc[i].ToString(), del);
                    if (result == 0)
                    {
                        Console.WriteLine("Deleted disk = " + i);
                        disc.Add(i, newDiscName);
                    }

                    else
                    {
                        string newDiscPos = "0";
                        newDiscPos = string.Concat(newDiscPos, disc.Count + 1);
                        disc.Add(newDiscPos, newDiscName);
                        Console.WriteLine("Диск c именем " + newDiscName + " успешно добавлен, его позиция [" + newDiscPos + "]");
                    }
                }




                PrintAllCatalog(disc);
                Console.WriteLine("Введите порядковый номер диска, который надо удалить");
                string line = Console.ReadLine();
                if (disc.Contains(line))
                {
                    ICollection keyS = songs.Keys;
                    int N = 0;
                    foreach (string i in keyS)
                    {
                        string buff = i.Substring(0, 2);
                        if (line == buff)
                        {
                            N++;
                        }
                    }
                    string[] delBuff = new string[N];
                    int j = 0;
                    foreach (string i in keyS)
                    {
                        string buff = i.Substring(0, 2);
                        if (line == buff)
                        {
                            delBuff[j] = i;
                            j++;
                        }
                    }
                    for (int i = 0; i < delBuff.Length; i++)
                    {
                        songs.Remove(delBuff[i]);
                    }
                    disc[line] = del;
                }
                else Console.WriteLine("Нет такого диска");

             
                Console.WriteLine("Информация о дисках");
                PrintAllCatalog(disc);
                Console.WriteLine("Количество дисков:" + disc.Count);
                Console.WriteLine("\nИнформация об аудиозаписях");
                PrintAllCatalog(songs);
                Console.WriteLine("Songs count:" + songs.Count);

                Console.WriteLine("Enter key of CD disc if you wanna show info about disc song");
                line = Console.ReadLine();
                if (disc.ContainsKey(line))
                {
                    Console.WriteLine("Disk[" + line + "] = " + disc[line]);
                    ICollection keyS = songs.Keys;
                    foreach (string i in keyS)
                    {
                        string buff = i.Substring(0, 2);
                        if (line == buff)
                        {
                            Console.WriteLine("Song[" + i + "] = " + songs[i]);
                        }

                    }
                }
                else Console.WriteLine("Not enough info about disc:" + line);
            
            }
        
    }
}
    

