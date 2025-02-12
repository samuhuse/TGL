namespace TglTest.Client.Models;

public class ApiProductResponse
{
    public List<Product> Products { get; set; } = [];
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}

public class ApiPostResponse
{
    public List<Post> Posts { get; set; } = [];
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}
