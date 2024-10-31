using Task.Models;

namespace Task.Services.Interfaces
{
    public interface ISliderImageService
    {
        Task<List<SliderImage>> GetAllAsync();
    }
}
