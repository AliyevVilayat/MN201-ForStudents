
using Core.Entities;
using DataAccess.Services;

PostService service = new();

//Post? post = await service.GetPostByIdAsync(1);
//Post? postAPI = await service.GetPostByIdFromAPIAsync(1);

await service.AddPost(2);
