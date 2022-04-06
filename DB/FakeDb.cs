using GregsListCSharp.Models;

namespace GregsListCSharp.DB;

public static class FakeDb
{
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
        new Car("Mickar", 12, true),
        new Car("Markar", 12, true)
    };
}