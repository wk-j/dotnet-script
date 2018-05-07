object obj = "Int32";
string str1 = "Int32";
string str2 = typeof(int).Name;

Console.WriteLine(obj == str1);
Console.WriteLine(str1 == str2);
Console.WriteLine(obj == str2);

String a = "a-" + typeof(int).Name;
Console.WriteLine(Object.ReferenceEquals(a, "a-Int32"));