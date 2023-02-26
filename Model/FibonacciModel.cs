namespace demo_test_api.Model;

public class Fibonacci
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int fic { get; set; }
    public DateTime CreatedTimestamp { get; set; }

}

public class dtoFibonacci
{
    public string? id { get; set; }
    public int input { get; set; }
    public int result { get; set; }
    public string? resultstep { get; set; }
    public int statuscode { get; set; }

}

public class data
{
    List<dtoFibonacci>? dtoFibonacci { get; set; }
}

