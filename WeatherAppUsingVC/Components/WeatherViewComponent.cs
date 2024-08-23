using Microsoft.AspNetCore.Mvc;
using WeatherAppUsingVC.Models;

namespace WeatherAppUsingVC.Components
{
    public class WeatherViewComponent:ViewComponent
    {
        public async  Task<IViewComponentResult> InvokeAsync(CityWeather city)
        {
            ViewBag.CssStyle = GetCssClassByFahrenheit(city.TemperatureFahrenheit);
            return View(city);

        }
       private string GetCssClassByFahrenheit(int TemperatureFahrenheit)
        {
            return TemperatureFahrenheit switch
            {
                (< 44) => "blue-back",
                (>= 44) and (< 75) => "green-back",
                (>= 75) => "orange-back"
            };
        }
    }
}
