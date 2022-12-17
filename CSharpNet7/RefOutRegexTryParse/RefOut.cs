
namespace RefOutRegexTryParse;
    internal class RefOut
    {
        public static void ChangeVar(int a,int b)
        {
            
            int tam = a;
            a = b;
            b = tam;
        Console.WriteLine("Chang value : ");
        Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");
        }
    //doi bien toan cuc
    public static void ChangeVar2(ref int a, ref int b)
    {

        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine("Chang value toan cuc : ");
        Console.WriteLine($"{nameof(a)}={a},{nameof(b)}={b}");
    }
    public static void ChangeVar3(out int c, out int d)
    {
        c = 10;
        d = 5;
        int tam = c;
        c = d;
        d = tam;
        Console.WriteLine("Chang value out : ");
        Console.WriteLine($"{nameof(c)}={c},{nameof(d)}={d}");
    }
}

