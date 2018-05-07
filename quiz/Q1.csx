var k1 = new KeyValuePair<int,int>(10, 29);
var k2 = new KeyValuePair<int,int>(10, 31);
Console.WriteLine(k1.GetHashCode() == k2.GetHashCode());


var v1 = new KeyValuePair<int,string>(10, "abc");
var v2 = new KeyValuePair<int,string >(10, "def");
Console.WriteLine(v1.GetHashCode() == v2.GetHashCode());