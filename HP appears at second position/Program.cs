
string sentnce = "PHP Tutorial";

string HP = sentnce.Substring(1, 2);


Console.WriteLine(HP);
//firstManner
if (sentnce.Contains("HP"))
{

   string remove= sentnce.Remove(1, 2);

    Console.WriteLine(remove);
}

//Second manner

if (sentnce.Substring(1, 2) == "HP")
{

    string remove2= sentnce.Remove(1, 2);

    Console.WriteLine(remove2 + " second manner");
}