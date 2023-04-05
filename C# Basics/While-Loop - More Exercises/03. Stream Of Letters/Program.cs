using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            char character;
            string word = "";
            string currentWord = "";

            bool letterCseen = false;
            bool letterOseen = false;
            bool letterNseen = false;


            while ((input = Console.ReadLine()) != "End")
            {
                character = char.Parse(input);
                if (char.IsLetter(character))
                {
                    if (character == 'c')
                    {
                        if (letterCseen == false)
                        {
                            letterCseen = true;
                        }
                        else
                        {
                            currentWord += character;
                        }
                    }
                    else if (character == 'o')
                    {
                        if (letterOseen == false)
                        {
                            letterOseen = true;
                        }
                        else
                        {
                            currentWord += character;
                        }
                    }
                    else if (character == 'n')
                    {
                        if (letterNseen == false)
                        {
                            letterNseen = true;
                        }
                        else
                        {
                            currentWord += character;
                        }
                    }
                    else
                    {
                        currentWord += character;
                    }

                    if (letterCseen == true && letterOseen == true && letterNseen == true)
                    {
                        currentWord += " ";
                        word = currentWord;
                        letterCseen = false;
                        letterOseen = false;
                        letterNseen = false;


                    }
                }
            }
            Console.Write($"{word}");

        }
    }
}