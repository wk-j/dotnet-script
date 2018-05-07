bool TryParse(string text, out int output)
{
    var digits = text.ToCharArray().Select(char.GetNumericValue);
    return Int32.TryParse(string.Join("", digits), out output);
}

var ok = TryParse("๑๒๓", out int n);
if (ok) Console.WriteLine(n);