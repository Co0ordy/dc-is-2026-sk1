Console.WriteLine("hellloo");

string again = "a";

//Řídící cyklus programu
/*
ToLower převede vstup na malá písmena, taže program pokračuje při zadání "a" i "A"
cokoliv jiného program ukončí
*/

while(again.ToLower() == "a")
{
    Console.WriteLine(" \n Pro opakování kédu stiskněte písmeno A a pro potvrzení stisknĚte Enter");
    again = Console.ReadLine()?? "";
    
}