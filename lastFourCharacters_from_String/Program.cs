
string sentence = "The quick brown fox jumps over the lazy dog.";


string endFour = sentence.Substring(sentence.Length-4);


Console.WriteLine(endFour+endFour+endFour+endFour);



static void lastFourCharcters(string sentence)
{


    string endFour1 = sentence.Substring(sentence.Length - 4);

    Console.WriteLine(endFour1+endFour1+endFour1+endFour1);
};


string sentence1 = "The besa way is to find.";


lastFourCharcters(sentence1);
