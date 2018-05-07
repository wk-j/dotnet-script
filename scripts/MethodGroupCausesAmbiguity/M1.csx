
void Function(Func<string> func) { }
void Function(Func<int> func) { }

int Source1() => 1;
string Source2() => "value";

Function(Source1);

// error CS0121: The call is ambiguous between the following methods or properties: 
// 'Function(Func<string>)' and 'Function(Func<int>)'

