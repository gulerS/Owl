using Microsoft.AspNetCore.Http;

namespace OwlSchool.Application.Services.ImageService
{
    public interface IImageService
    {
        string Upload(IFormFile formFile);
        string Update(IFormFile formFile, string imageUrl);
        void Delete(string imageUrl);
    }
}
