#! "netcoreapp2.0"
#r "nuget: NetStandard.Library, 2.0.0"
#r "nuget:Newtonsoft.Json,11.0.2"

using Newtonsoft.Json;

public class Data {
    int a = 0;
    int b = 5;
    int c = 5;

    public int C {
        set {
            Console.WriteLine("set c");
            c = value;
        }
        get {
            Console.WriteLine("get c");
            return c;
        }
    }

    public int B {
        set {
            Console.WriteLine("set b");
            b = value;
        }
        get {
            Console.WriteLine("get b");
            return b;
        }
    }

    public int A {
        get {
            Console.WriteLine("get a");
            return a;
        }
        set {
            Console.WriteLine("set a");
            a = B - 1;
        }
    }

}

var json = "{\"a\": 2, \"b\": 2, \"c\": 2 }";

var data = JsonConvert.DeserializeObject<Data>(json);

Console.WriteLine(data.A);
Console.WriteLine(data.B);
Console.WriteLine(data.C);
