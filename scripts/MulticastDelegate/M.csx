

Action<object> action = (a) => { };

action += (a) => Console.WriteLine($"Added 1 {a}");
action += (a) => Console.WriteLine($"Added 2 {a}");
action += (a) => Console.WriteLine($"Added 3 {a}");

void A(int i) { }

action("Hello");
