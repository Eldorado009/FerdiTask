
using Microsoft.AspNetCore.Mvc;
using Task.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using Task.ViewModels;

namespace Task.ViewCompanents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderImageService _sliderImageService;
        private readonly ISliderService _sliderService;

        public SliderViewComponent(ISliderService sliderService,
                                    ISliderImageService sliderImageService)
        {
            _sliderImageService = sliderImageService;
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await System.Threading.Tasks.Task.FromResult(View(new SliderHomeVM()
            {
                Slider = await _sliderService.GetAsync(),
                SliderImages= await _sliderImageService.GetAllAsync()

            }));
        }
    }
}
