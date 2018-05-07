// https://github.com/dotnet/csharplang/issues/1377
(int x, int y, int z) testFunc(int x) {
    return (x, x, x);
}

var (x, y, z) = testFunc(100);

if (testFunc(100) is (0, 1, 2)) { }