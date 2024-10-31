using Task.Models;

namespace Task.Services.Interfaces
{
    public interface ISliderService
    {
        Task<Slider> GetAsync();
    }
}
