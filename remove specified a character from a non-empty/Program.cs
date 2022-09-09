
//remove (3)
string data = "w3resource";

string data1 = data.Remove(1,1);

Console.WriteLine(data1);

//remove end (e)

string data_e = data.Remove(data.Length-1);

Console.WriteLine(data_e);

//remove first letter

string dataw = data.Remove(0,1) ;
Console.WriteLine(dataw);