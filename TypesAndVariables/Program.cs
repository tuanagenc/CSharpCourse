﻿int number1 = 10;
long number2 = 200;
short number3 = 5;
byte number4 = 0;
bool condition = false; //şart
char character = 'A';
double number5 = 10.5;  //Ondalık sayıları tutar
decimal number6 = 10.5m;
var number7 = 200;



// int değeri -2147483648 ve bunun +2147483647 değeriyle sınırlıdır ve 32 bittir.
// long değeri -9223372036854775808 ve bunun +9223372036854775807 değeriyle sınırlıdır ve 64 bittir.
// short değeri -32768 ve bunun +32767 değeriyle sınırlıdır ve 16 bittir.
// byte değeri 0 ve 255 değeriyle sınırlıdır, 8 bittir.
// bool ifadesi true ve false değerlerini tutar.
// char ifadesi tek bir karakteri içinde barındırır
// double veri türü ondalıklı değerleri içinde barındırır.
// decimal veri türü, double veri türüne göre virgülden sonra daha fazla basamak barındırır.
// enum kullanarak string ifadelerini fazla kez yazmaktan kurtulabiliriz.
// var değerinde eşitliğin diğer tarafına hangi değer yazılırsa var tipi o değerin türüyle eşitlenir.


Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Characterbis : {0}", character);
Console.WriteLine("Number5 is {0}", number5);
//Doubleden farkı daha hassas bir sayı olması ve virgülden sonra daha fazla sayı alabilmesi
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine(Days.Friday);
Console.WriteLine("Number7 is {0}", number7);


Console.ReadLine();

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}



