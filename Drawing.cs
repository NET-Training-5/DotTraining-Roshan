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
}