var x = new Array[5].Select((_, i) => DateTime.Now.Year + i);

class A
{
    public int X { set; get; }
}

var a = new A();
if (a is A aa) aa.X = 100;

Console.WriteLine(aa.X);

struct B
{
    public int X { set; get; }
}

var b = new B();
if (b is B bb) bb.X = 100;
Console.WriteLine(b.X);
