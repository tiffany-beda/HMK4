using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Security.Cryptography.X509Certificates;

public class Homework4 {

    static void Main ()
    {  // Console.Writeline(countWords("Just an example here move along")); 
       //Console.WriteLine(FlipEndChars("Cat, dog and mouse."));
       //Console.WriteLine(isInOrder("abc"));
       //Console.WriteLine(FirstNVowels("sharpening skills",3));
       Console.WriteLine(Move("hello"));

    }


/*static int countWords(string word){ part 1 

int count = 0;
bool inWord = false;

for (int i = 0; i < word.Length;i++)
{
   if (word[i] != ' ' )
    {
        if (!inWord)
        {
                count ++;
                inWord = true ; 

        }
    }
    else
   
         {inWord = false ;}
         
}
return count ;


    }*/

/* static string FlipEndChars(string sentence) part 2

{
        
            if(sentence.Length < 2)
            {
                return "Incompatible";
            }
            else if (sentence[0] == sentence[^1])
            {
                return "Two's a pair";
            }

            char first = sentence[0];
            char last = sentence[^1];
            string swappedWord = last +sentence[1..^1] + first;
        
        return swappedWord;
}*/


/*static bool isInOrder( string word ) part 3 
{
    for (int i = 0 ;i < word.Length-1; i++ )
    {
        if (word[i] > word[i + 1])
        {
            return false ;
        }

    }
    return true;
} */


/*static string FirstNVowels(string sentence, int vowelsNum)part 4
{
    int count = 0;
    string vowels = "";


#pragma warning disable CS0162 // Unreachable code detected
        for (int i = 0; i < sentence.Length; i++)
        {
             if ("aeiuo".Contains(sentence[i]))
             {
                    count++;
                    vowels += sentence[i];
                    if (count == vowelsNum)
                    {
                        return vowels;
                    }

             }
            
        }return "Invalid";
#pragma warning restore CS0162 // Unreachable code detected
    }*/

static string Move (string word) //part5
{
    string newWord = "";
    for (int i = 0 ;i < word.Length; i++)
        {
            char  newChar = (char) (word[i]+1);
            newWord += newChar;
        }

        return newWord;
}

}


