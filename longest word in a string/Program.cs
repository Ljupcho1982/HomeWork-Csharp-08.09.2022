
string[] sentence = { "Write", "a", "C#", "Sharp", "Program", "to", "display", "the", "following", "pattern", "using", "the", "alphabet" };



//string one = sentence[0].ToString();

//Console.WriteLine(one);

//string word = "";
//int ctr = 0;


//foreach (string s in sentence)
//{

//    if (s.Length > ctr)
//    {
//        word = s;


//        ctr = s.Length;
        
//    }

//}
//    Console.WriteLine(word);

void theLongestWord(string [] sentence) 
{

    string word = "";// a  stringvariable word is declecred which will contain the words;

    int one = 0;// a int variable is declered which will contain the lenght of word

    foreach (string s in sentence)
    {


        if (s.Length > one) //compering lenght of word with int one
        {
            word = s;       //holding the longest string word form each iternation


            one = s.Length; // holding the longest int from each iteration

        }

        


    }

    Console.WriteLine(word);
};

theLongestWord(sentence);

string[] sentecne1 = { "FDDFGDF", "dfdfdfd", "Dfdffgfdgfgdfgdf" };

theLongestWord(sentecne1);
