using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Interfaces
{
    interface ICultureService
    {
        List<CultureModel> GetListCulture();
    }
}
