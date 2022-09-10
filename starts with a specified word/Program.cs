
string [] input = { "Hello","how", "are", "you?"};

string start = input[0];

Console.WriteLine(start);

//first manner
if(start == "Hello")
{

    Console.WriteLine("true");
}
else
{

    Console.WriteLine("false");
}

//second manner

bool isTrue = start=="Hello";

Console.WriteLine(isTrue);



