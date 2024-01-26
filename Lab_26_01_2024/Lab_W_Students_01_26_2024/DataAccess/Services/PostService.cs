using Core.Entities;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace DataAccess.Services;

//1.  Method İd qəbul edir +
//APİ-dən həmin İd-li objecti-
//database-ə əlavə edir.-
//Əgər artıq o object mövcuddursa xəbərdarlıq edir. +

public class PostService
{
    private readonly string _connectionStr = @"Server = localhost; Database=LabDB;Trusted_Connection = True;";
    public async Task AddPost(int id)
    {
        //Database check ...
        bool exist = await CheckExistPostAsync(id); ;
        if(exist)
        {

            Console.WriteLine("Database daxilinde bu id-e qarsiliq obyekt movcuddur.");
        }
        else
        {
           Post? postAPI = await GetPostByIdFromAPIAsync(id); 

            if(postAPI is not null)
            {
                //save to db
                SaveToDb(postAPI);
            }
            else
            {
                Console.WriteLine("API-dan gelen obyekt null deyere sahibdir.");
            }
        }
        //if not null ...
        //else add method() ...
    }


    public async Task<Post?> GetPostByIdAsync(int id)
    {
        string query = "SELECT * FROM Posts WHERE Id = @id ";
        Post? post = default;
        using (SqlConnection connection = new SqlConnection(_connectionStr))
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            #region ExecuteReader
            SqlDataReader reader = await command.ExecuteReaderAsync();

            while (reader.Read())
            {
                post = new()
                {
                    Id = (int)reader["Id"],
                    UserId = (int)reader["UserId"],
                    Title = (string)reader["Title"],
                    Body = (string)reader["Body"],

                };
            }
            #endregion
        }

        return post;
    }

    public async Task<Post?> GetPostByIdFromAPIAsync(int id)
    {
        Post? post = default;
        string url = $"https://jsonplaceholder.typicode.com/posts/{id}";

        using (HttpClient client = new HttpClient())
        {

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                post = JsonConvert.DeserializeObject<Post?>(content);

            }
        }

        return post;
    }

    #region Check Exist Post
    public async Task<bool> CheckExistPostAsync(int id)
    {
        string query = $"SELECT * FROM Posts WHERE Id ={id} ";
        using (SqlConnection connection = new SqlConnection(_connectionStr))
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            if (reader.Read())
            {
                return true;
            }
        }

        return false;
    }

    #endregion


    #region Save to DB
    public void SaveToDb(params Post[] posts)
    {
        if (posts is not null && posts.Length > 0)
        {
            string query = "INSERT INTO Posts (Id, UserId, Title, Body) VALUES (@id, @userId, @title, @body);";
            using SqlConnection connection = new(_connectionStr);
            connection.Open();

            foreach (var post in posts)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", post.Id);
                command.Parameters.AddWithValue("@userId", post.UserId);
                command.Parameters.AddWithValue("@title", post.Title);
                command.Parameters.AddWithValue("@body", post.Body);

                command.ExecuteNonQuery();
            }
        }
    }
    #endregion
}
