namespace degiskenler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(""); 

        byte b = 5; //0 ile 255 arasında değer alır. 1 byte yerkaplar.
        sbyte c =5;//-128 ile 127 arasında değer alır. 1 byte yer kaplar.
        short s=5;//-32768 ile 32768 rasında değer alır.2 byte yer kaplar.
        ushort us= 5; //0 ile 65365 arasında değer alır.2 byte yer kaplar.
        Int16 i16=2;//2 byte yer kaplar.
        int i=2;//4 byte yer kaplar.
        Int32 i32=2;//4 byte yer kaplar.
        Int64 i64=2;//8 byte yer kaplar.
        uint ui=2;//4 byte yer kaplar.
        long l=4;//8 byte yer kaplar.
        ulong ul=4;//8 byte yer kaplar.
        float f=5;//4 byte yer kaplar.
        double d=5;//8 byte yer kaplar.
        decimal de=5;// 16 byte yer kaplar.
        char ca='2';// 2 byte yer kaplar.
        string st="kdfaşsk";//sınırsız byte yer kaplar.
        bool bl= true;
        DateTime dt= DateTime.Now;//o anın tarih ve saatini yazdırır
        object o1="x";
        object o2='y';
        object o3= 4;
        object o4=4.3;

        string str1=null;
        string str2= string.Empty;
        str2= "Ayşe yıldırım";

        int in1=5;
        int in2=3;
        int in3=in1*in2;

        bool bool1=10<2;

        string str20="20";
        int int20=20;
        string yenideger=str20+int20.ToString();//çıktı 2020
        int int21=int20+Convert.ToInt32(str20);//çıktı 40
        int int22=int20+int.Parse(str20);//çıktı 40

        string datetime=DateTime.Now.ToString("dd.MM.yyyy");
        string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
        string hour=DateTime.Now.ToString("HH:mm");

        

    }
}
