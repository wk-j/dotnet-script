#r "nuget: System.Memory, 4.4.0-preview1-25305-02"

unsafe
{
    var vals = stackalloc int[3];
    vals[0] = 1;
    vals[1] = 2;
    vals[2] = 3;
    var x = new Span<int>(vals, 3);
};