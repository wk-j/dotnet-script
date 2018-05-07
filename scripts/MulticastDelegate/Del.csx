delegate void CustomDel(string s);

static void Hello(string s)
{
    System.Console.WriteLine("  Hello, {0}!", s);
}

static void Goodbye(string s)
{
    System.Console.WriteLine("  Goodbye, {0}!", s);
}


CustomDel hiDel, byeDel, multiDel, multiMinusHiDel; 
hiDel = Hello;
byeDel = Goodbye;
multiDel = hiDel + byeDel;
multiMinusHiDel = multiDel - hiDel;

Console.WriteLine("Invoking delegate hiDel:");
hiDel("A");
Console.WriteLine("Invoking delegate byeDel:");
byeDel("B");
Console.WriteLine("Invoking delegate multiDel:");
multiDel("C");
Console.WriteLine("Invoking delegate multiMinusHiDel:");
multiMinusHiDel("D");