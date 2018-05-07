
class A {
    public static bool operator ==(A left, int right) => true;
    public static bool operator !=(A left, int right) => !(left == right);
}

var a = new A();

if (a == 1 && a == 2 && a == 3) {
    Console.WriteLine("Hello, world!");
}

