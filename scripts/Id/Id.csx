
var list = new List<int> { 10, 2, 3, 3, 4, 5 };

T id<T>(T t) => t;


var rs = list.OrderBy(id);
var rs2 = list.OrderByDescending(id);
Console.WriteLine(string.Join(", ", rs));
Console.WriteLine(string.Join(", ", rs2));
