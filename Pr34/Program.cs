Console.WriteLine("Введите любое количество положительных трехзначных чисел через запятую");
 static void Count()
        {
            string s = Console.ReadLine();
            string[] line = s.Split(',');
            int[] array = new int[line.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(line[i]);
                if (array[i] % 2 == 0)
                {
                count++;
                }
            }
            Console.WriteLine($"{count}");
        }
        Count();