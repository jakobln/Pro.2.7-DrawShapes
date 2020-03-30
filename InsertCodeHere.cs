namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            System.Console.WriteLine("Shape A:");
            for (int number = 0; number < 10; number = number + 1)
            {
                DrawingTool.DrawOneStar();
            }
            System.Console.WriteLine();

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            System.Console.WriteLine("Shape B:");
            for (int number = 0; number < 5; number = number + 1)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }
            System.Console.WriteLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //

            System.Console.WriteLine("Shape C:");
            for (int number = 0; number < 10; number = number + 1)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneStar();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //
            System.Console.WriteLine("Shape D:");
            for (int number = 0; number < 10; number = number + 1)
            {
                for (int i = 0; i <= number; i++)
                {            
                      DrawingTool.DrawOneStar();
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *
            System.Console.WriteLine("Shape E:");
            int column = 0;
            int row = 0;
            
            if (column == row || column + row == 9)
            {
                DrawingTool.DrawOneStar();
            }
            else
            {
                System.Console.WriteLine("");
            }


            /*for (int number = 0; number < 10; number = number + 1)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneSpace();
                DrawingTool.DrawOneStar();
                System.Console.WriteLine();
                for (int i = 0; i <= number; i++)
                {            
                      DrawingTool.DrawOneSpace();
                }
            }*/
            System.Console.WriteLine();

            // The LAST line of code should be ABOVE this line

        }
    }
}