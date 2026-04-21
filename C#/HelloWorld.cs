using System;

class Program
{
    static void Main()
    {
        string A =
"  #    #          #  #            ##   #    #            #      #  #     \n" +
"  #    #          #  #             #   ##  ##            #      #  #     \n" +
"  #    #          #  #             #  ###  #             #      #  #     \n" +
"  #    #   ####   #  #  ####       #  # #  #  ####   # # #  ### #  #     \n" +
"  ######  #    #  #  # ##  ##      #  # #  # ##  ##  ##  # ##  ##  #     \n" +
"  #    #  ######  #  # #    # ###   # #  # # #    #  #   # #    #  #     \n" +
"  #    #  #       #  # #    #       ##   ##  #    #  #   # #    #  #     \n" +
"  #    #  ##  ##  #  # ##  ##       ##   ##  ##  ##  #   # ##  ##        \n" +
"  #    #   ####   #  #  ####        ##   ##   ####   #   #  ### #  #     \n\n";

        for (int i = 0; i < 7; i++)
        {
            Console.ForegroundColor = (ConsoleColor)i;
            Console.Write(A);
        }

        for (int i = 8; i < 15; i++)
        {
            Console.ForegroundColor = (ConsoleColor)i;
            Console.Write(A);
        }

        Console.ResetColor();
    }
}
