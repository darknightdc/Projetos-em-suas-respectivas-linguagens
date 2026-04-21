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

        // Cores normais
        for (int i = 0; i < 7; i++)
        {
            Console.ForegroundColor = (ConsoleColor)i;
            Console.Write(A);
        }

        // Cores "bright" (equivalente aproximado)
        for (int i = 8; i < 15; i++)
        {
            Console.ForegroundColor = (ConsoleColor)i;
            Console.Write(A);
        }

        Console.ResetColor();
    }
}