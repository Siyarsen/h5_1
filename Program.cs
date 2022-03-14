// Bankamatiğe şifre ve isim girilmesi örneği
/*string kad = "admin";
string ksifresi = "123";
string kullaniciad, kullanicisifre;

int hak = 3;
do
{
    Console.Write("Kullanıcı adı giriniz:");
    kullaniciad = Console.ReadLine();
    Console.Write("Kullanıcı şifresini giriniz: ");
    kullanicisifre = Console.ReadLine();
    if (kullaniciad == kad && kullanicisifre == ksifresi)
    {
        Console.Write("HOŞGELDİNİZ......");
    }
    else
    {
        hak--;
        if (hak == 0)
        {
            Console.Write("3 defa kullanıcı adı ve şifresi girme hakkınız var.Lütfen tekrar deneyiniz...");
        }
    }
} while ((kullaniciad != kad || kullanicisifre != ksifresi) && hak!= 0);
Console.ReadKey();
*/
  
// DİZİ OLUŞTURMA (STRİNG)
/*
string[] isimler;         //string[] isimler=new string[] {"İZMİR","BAKIRÇAY","ÜNİVERSİTESİ"};
isimler = new string[3]; //string[] isimler=new string[3] şeklinde de yazdırabiliriz.
 isimler[0]= "İZMİR";
isimler[1]= "BAKIRÇAY";
isimler[2]= "ÜNİVERSİTESİ"; 
foreach (var item in isimler)
{
Console .WriteLine("isimler:"+item);
}

// DİZİ OLUŞTURMA (İNT)
int k=0;
int[]dizi=new int[10];//diziye ait nesne oluştu
k=dizi.Length;
Console.WriteLine("Dizinin uzunluğu :" + k);
int[] dizi2 = { 5, 9, 13, 85 };
float[] dizi3 = { 8f, 12f, 65f, 5.96f };
foreach (int item in dizi2)  //foreach (var item in dizi2) olarak da yazabilmek mümkündür.
{
    Console.WriteLine("dizi2:" + item);
}
foreach (var item in dizi3)
{
    Console.WriteLine("dizi3:" + item);
}
*/
/*
Random rnd = new Random();
int[]dizi=new int[3];
dizi[0]=rnd.Next(2,10); // 2 İLE 10 ARASINDA BİR DEĞER ALIR
dizi[1] = rnd.Next(50); //0 İLE 50 ARASINDA DEĞER ALACAK
dizi[2] = rnd.Next();   // RASTGELE İNTEGER DEĞER ALIR
foreach (var item in dizi)
{
    Console.WriteLine(item);
}
int k =dizi.Length;
for (k = 0; k < 3; k++) // 0-10 arası
{
    dizi[k]=rnd.Next(10);
    Console.WriteLine("dizinin {0},dizi [{0}]",k,dizi[k]);
}
*/

//MATRİS OLARAK YAZIM
int[,] cokBoyut =new int[2,5];  //[m,n];
int m =cokBoyut.GetLength(0),n=cokBoyut.GetLength(1);
Console.WriteLine("ÇOK BOYUTLU DİZNİN SATIR SAYISI {0} VE KOLON SAYISI {1}'DİR.", m, n);
Random rs=new Random();
for (int i = 0; i < cokBoyut.GetLength(0); i++) //çok boyutlu dizilrde dizi olarak düşünüyor getlenght satır ve sutün sayısı olarak kullanıyor .
{
    for (int j= 0; j < cokBoyut.GetLength(1); j++)
    {
        cokBoyut[i, j] = rs.Next(2, 50);
        Console.Write(" [{0},{1}]={2} ",i,j,cokBoyut[i,j]);
    }
}Console.WriteLine();