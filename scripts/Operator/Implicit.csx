
class A {
    private int value = 0;
    public static implicit operator int(A a) => a.value ++;      
}

var a = new A();

if (a == 0 && a == 1 && a == 2) {
    Console.WriteLine("Hello, world!");
}


