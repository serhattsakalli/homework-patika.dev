namespace Odev1;

class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n)
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        Console.WriteLine("lütfen bir sayı giriniz");
        int sayı1=int.Parse(Console.ReadLine());
        int[] say=new int[sayı1];
        for (int i = 0; i < sayı1; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+".Sayıyı Giriniz");
            say[i]=int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < sayı1; i++)
        {
            if(say[i]%2==0)
            Console.WriteLine(say[i]);
        }

       // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
       // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        Console.WriteLine("lütfen birinci sayıyı giriniz");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("lütfen ikinci sayıyı giriniz");
        int b=int.Parse(Console.ReadLine());
        int[] kelimeler=new int[a];
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+".Sayıyı Giriniz");
            kelimeler[i]=int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < a; i++)
        {
            if(kelimeler[i]%b==0||kelimeler[i]==b)
            Console.WriteLine(kelimeler[i]);
        }


        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        Console.WriteLine("lütfen bir sayı giriniz");
        int v=int.Parse(Console.ReadLine());
        string[] kelime=new string[v];
        for (int i = 0; i < v; i++)
        {
            Console.WriteLine("Lütfen "+(i+1)+".kelimeyi Giriniz");
            kelime[i]=Console.ReadLine();
        }
        foreach (var item in kelime)
        {
            Console.WriteLine(item);
        }


        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.WriteLine("lütfen bir cümle giriniz");
        string c=Console.ReadLine();
        int count=0;
        for (int i = 0; i < c.Length; i++)
        {
            if(c[i]== ' ')
            count++;
        }
        Console.WriteLine("cümlenizde :"+(count+1)+" adet kelime ve"+(c.Length-count)+" adet harf bulunuyor");



        Console.ReadKey();
    }
}
