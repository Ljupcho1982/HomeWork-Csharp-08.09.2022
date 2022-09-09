

string[] sentence = { "Display", "the", "pattern", "like", "pyramid", "using", "the", "alphabet." };



//for (int i =sentence.Length-1; i >=0; i--)
//{
//    string str = sentence[i];

//    Console.Write(str+" ");

//}






void reverseSentnce(string[] sentence)
{
    for(int i=sentence.Length-1; i>=0; i--)
    {

        string str = sentence[i];

        Console.Write(str + " ");
    }

    
};


reverseSentnce(sentence);


