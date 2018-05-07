async Task<int> F1()
{
    Console.WriteLine("f1");
    var x = Task.Factory.StartNew(() => 1);
    return await x;
}

async Task<int> F2()
{
    Console.WriteLine("f2");
    var x = Task.Factory.StartNew(() => 1);
    return await x;
}


var rs = Task.WhenAll(new[] {
    F1(),
    F1(),
    F1(),
    F2(),
    F2(),
    F2()
 });
