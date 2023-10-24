namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students2 = new string[3] { "Engin", "Tuana", "Efrun" };


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            string[,] regions = new string[7, 3]
            {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara", "Konya","Kırıkkale" },
                { }
                { }
                { }
                { }
                { }

            }
            Console.WriteLine();
            Console.ReadLine();
            //students[0] = "Engin";
            //students[1] = "Tuana";
            //students[2] = "Efrun";
            //{
            //    Console.WriteLine(students[1]);
            //}

        }
    }
}



