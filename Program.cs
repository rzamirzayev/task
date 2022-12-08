//Task1
Console.WriteLine("Eded giriniz:");
int eded = Convert.ToInt32(Console.ReadLine());
if (eded % 2 == 0)
{
    Console.WriteLine(eded / 2);
}
else
{
    Console.WriteLine(eded * 2);
}
//Task2
int cem =0;
for (int i=0;i<10;i++)
{
    cem+=i;
}
Console.WriteLine("0dan 10a qeder olan ededlerin cemi:"+cem);
//Task3
int say=0;
for(int j = 0; j <= 100; j += 5)
{
    say++;
}
Console.WriteLine("0dan 100e qeder olan 5e bolunen ededlerin sayi:" + say);
//Task5
Console.WriteLine("Yasinizi daxil edin:");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
{
    Console.WriteLine("Suruculuk vesiqesi ala bilersiniz.");
}
else
{
    Console.WriteLine("Siz "+(18-yas)+" il sonra suruculuk vesiqesi ala bilersiniz.");
}

//task4
Console.WriteLine("cumle daxil edin:");
string cumle= Console.ReadLine();
char[] cumle2= new char[cumle.Length];
for (int j = 0; j < cumle.Length; j++)
{
    cumle2[j] = cumle[j];
}
for (int j = 0; j < cumle2.Length; j++)
{
    if (cumle2[j] == ',')
    {
        cumle2[j] = '.';
    }
}
string yeni_cumle= string.Join("", cumle2);
Console.WriteLine(yeni_cumle);



