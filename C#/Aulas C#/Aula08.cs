using System;

namespace String
{
    class Strings
    {
        static void Main(string[] args)
        {
            // varName.length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            // toUpper.toLower
            string sentenca = "Il giorno è quando il sole è in cielo";
            Console.WriteLine(sentenca.ToLower());
            Console.WriteLine(sentenca.ToUpper());


            // Concatenation

            string x = "10";
            string y = "20";
            string z = x + y;  // z will be 1020 (a string) / whether was int it must to add


            // Interpolation
            string pNome = "J";
            string nName = "Victor";

            string nickName = $"the nickname is: {pNome}{nName}";
            Console.WriteLine(nickName);


            // Acess String
            // stringName[index];
            Console.WriteLine(sentenca[4]); // i
            Console.WriteLine(sentenca.IndexOf("i"));
            int charPosition = sentenca.IndexOf("g");
            string senten = sentenca.Substring(charPosition);
            Console.WriteLine(senten);


            /* \'	'	Single quote
                \"	"	Double quote
                \\	\	Backslash

             \n	New Line	
            \t	Tab	
            \b	Backspace
             */
        }
    }
}