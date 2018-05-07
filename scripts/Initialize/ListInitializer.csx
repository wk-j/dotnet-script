
class C {
    public List<int> Data1 { get; } = new List<int>();
    public List<int> Data2 { get; }
}

var c = new C {
    Data1 = { 1, 2, 3, 4, 5 },  // 1
    Data2 = { 1, 2, 3, 4, 5 }   // 2
};

// List<int> list = { 1,2,3,4,5 };  // 3

