
using System.Runtime.CompilerServices;

public interface MAgeProvider
{
}

public static class AgeProvider
{
    static ConditionalWeakTable<MAgeProvider, Fields> table;

    private sealed class Fields
    {
        internal DateTime BirthDate = DateTime.UtcNow;
    }

    static AgeProvider()
    {
        table = new ConditionalWeakTable<MAgeProvider, Fields>();
    }

    /* 
    public static int GetAge(this MAgeProvider map)
    {
        var dtNow = DateTime.Now;
        var dtBorn = table.GetOrCreateValue(map).BirthDate;
        var age = ((dtNow.Year - dtBorn.Year) * 372 + (dtNow.Month - dtBorn.Month) * 31 + (dtNow.Day - dtBorn.Day)) / 372;
        return age;
    }
    */
}
