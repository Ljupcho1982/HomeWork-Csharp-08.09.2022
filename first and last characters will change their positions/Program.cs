//First manner
using System.Runtime.CompilerServices;

string data1 = "w3resource";

string data2 = "Python";

string data1_1 = data1.Substring(0, 1);
string data1_2 = data1.Substring(data1.Length-1);
string data1_3= data1.Substring(1, 8);
    
    
Console.WriteLine(data1_1);
Console.WriteLine(data1_2);

Console.WriteLine(data1_3);

string data4 = data1_2 + data1_3 + data1_1;

Console.WriteLine(data4);


string data2_1 = data2.Substring(0, 1);
string data2_2 = data2.Substring(data2.Length - 1);
string data2_3 = data2.Substring(1, 4);
Console.WriteLine(data2_1);
Console.WriteLine(data2_2);
Console.WriteLine(data2_3);
string data5 = data2_2 + data2_3 + data2_1;

Console.WriteLine(data5);

//second manner


char[] data10 = { 'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e' };


char one = data10[0];
char last = data10[data10.Length-1];
data10[0] = last;
data10[data10.Length - 1] = one;



Console.WriteLine(data10);


char[] data11 = { 'P', 'y', 't', 'h', 'o', 'n' };

static void swapFisrtLast(char[]data)
{
    char one = data[0];
    char last = data[data.Length - 1];
    data[0] = last;
    data[data.Length - 1] = one;

    Console.WriteLine(data);
}

swapFisrtLast(data11);


