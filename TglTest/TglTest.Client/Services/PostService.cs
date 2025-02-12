using System.Net.Http.Json;
using TglTest.Client.Models;

namespace TglTest.Client.Services;

public class PostService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async IAsyncEnumerable<Post> GetPostsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<ApiPostResponse>($"https://dummyjson.com/posts") ?? throw new Exception("Failed to fetch products");

        foreach (var post in response.Posts.SelectMany(_ => response.Posts.SelectMany(x => response.Posts)))
        {
            yield return post;
        }
    }

    public async Task<Post> GetPostAsync(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<Post>($"https://dummyjson.com/posts/{id}");

        return response ?? throw new Exception("Failed to fetch product");
    }
}
