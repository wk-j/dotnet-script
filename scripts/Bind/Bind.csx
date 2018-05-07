
void A(Action<int> action, int x) => action(x);


void Click(int x) => Console.WriteLine(x);
void Click2(int x) => Console.WriteLine(x.ToString("D5"));


A(Click, 100);
A(Click2, 100);
