using System;

namespace GuidUsage
{
    class Program
    {
        private static HexNumbersGenerator generator = new HexNumbersGenerator();
        private static FileCreator fileCreator = new FileCreator();
        private static NumericalSystemUtils utils = new NumericalSystemUtils();
        private static void Task()
        {
            string tasks1_3AllVariants = "";
            string tasks4_5AllVariants = "";
            string tasks6_7AllVariants = "";
            string tasks8_9AllVariants = "";

            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i < 50; i++)
            {
                generator = new HexNumbersGenerator();
                string variant = "";
                string tasks1_3 = ("\n №1 (hex to decimal):                        " + generator.HexByte + " = " + utils.HexToDecimal(generator.HexByte));
                tasks1_3 += ("\n №2 (Hex to binary):                         " + generator.HexByte + " = " + utils.HexToBinary(generator.HexByte));
                tasks1_3 += ("\n №3 (reverse bits):                          " + generator.HexByte + " = " + utils.ReverseBits(generator.HexByte));
                string tasks4_5 = ("\n №4 (sum hex numbers):                       " + generator.HexWord + " + " + generator.HexWord2 + " = " + utils.SumHexNumbers(generator.HexWord, generator.HexWord2));
                tasks4_5 += ("\n №5 (substruct hex numbers):                 " + generator.HexWord + " - " + generator.HexWord2 + " = " + utils.SubtructHexNumbers(generator.HexWord, generator.HexWord2));
                string tasks6_7 = ("\n №6 (signed hex to decimal):                 " + generator.HexByte + " = " + utils.HexSignedToDecimal(generator.HexByte));
                tasks6_7 += ("\n №7 (changing a hex sign):                   " + generator.HexByte + " = " + utils.HexChangeSign(generator.HexByte));
                string tasks8_9 = ("\n №8 (hex in additional code to decimal):     " + generator.HexByte + " = " + utils.HexAdditionalToDecimal(generator.HexByte));
                tasks8_9 += ("\n №9 (hex in additional code change sign):    " + generator.HexByte + " = " + utils.HexAdditionalChangeSign(generator.HexByte));

                tasks1_3AllVariants += "\nVariant " + (i + 1) + generator.ToString() + tasks1_3 + "\n";
                tasks4_5AllVariants += "\nVariant " + (i + 1) + generator.ToString() + tasks4_5 + "\n";
                tasks6_7AllVariants += "\nVariant " + (i + 1) + generator.ToString() + tasks6_7 + "\n";
                tasks8_9AllVariants += "\nVariant " + (i + 1) + generator.ToString() + tasks8_9 + "\n";

                variant += tasks1_3 + tasks4_5 + tasks6_7 + tasks8_9;
                Console.WriteLine(variant);

                fileCreator.WriteFile("Variant" + (i + 1) + ".txt", generator.ToString() + variant);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            fileCreator.WriteFile("Tasks 1-3.txt", tasks1_3AllVariants);
            fileCreator.WriteFile("Tasks 4-5.txt", tasks4_5AllVariants);
            fileCreator.WriteFile("Tasks 6-7.txt", tasks6_7AllVariants);
            fileCreator.WriteFile("Tasks 8-9.txt", tasks8_9AllVariants);
        }

        private static int Menu()
        {
            Console.Write("Choose option:\n1 - Task\n2 - Exit\n\nYour choise: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            while (true)
            {
                switch (Menu())
                {
                    case 1: Task(); break;
                    case 2: return;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }
            }
        }
    }
}
