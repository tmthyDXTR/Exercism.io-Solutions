using System;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private static int Value { get; set; }

    public Allergies(int mask)
    {
        Value = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return ((Allergen)Value & allergen) == allergen;
    }

    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(x => ((int)x & Value) > 0)
            .ToArray();
    }
}