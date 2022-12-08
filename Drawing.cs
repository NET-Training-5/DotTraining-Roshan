class Drawing{

      public void DrawPattern()
        {
            
            for(int row = 1; row <=6; ++row)
            {
                for(int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }


          public void DrawPattern2()
        {
            for(int row = 1; row <=6;  ++row)
            {
                for(int column = 1; column <= row; ++column)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }

        public (short, short) FindMinMax(params short[] numbers)
        {
            short min = short.MaxValue;
            short max= short.MinValue;
            foreach(var num in numbers)
            {
                if (num < min)
                min = num;

                if(num > max)
                max = num;

            }

            return (min, max);

            

        }
}