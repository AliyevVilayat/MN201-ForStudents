using Core.Entities;

namespace Core.Helper;

public static class Extension
{
    public static void DeconstructRecord(this Book book)
    {
        var (Title, Author, PublicationYear) = book;
        Console.WriteLine($"Bu kitabin basliqi:{Title} Yazicisi: {Author} Cap olundugu tarix {PublicationYear}");
    }
}
