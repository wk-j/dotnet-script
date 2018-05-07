struct Vector3
{
    public float X, Y, Z;
    public override string ToString() => $"{X} {Y} {Z}";
}

Vector3 v = new Vector3();
if (v is Vector3 v2)
{
    v2.Z = v2.Y;
    v2.Y = 1;
}

Console.WriteLine(v2);
