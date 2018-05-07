
using System.Text;

var text = "หวัดดี";
var bytes = Encoding.UTF7.GetBytes(text);

var rs = Encoding.UTF8.GetString(bytes);

Console.WriteLine(text == rs);
Console.WriteLine(rs);
