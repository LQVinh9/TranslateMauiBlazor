using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Services
{
    interface ITranslateService
    {
        Task<List<TranslateModel>> TranslateLanguage(string text, string[] languages);
    }
}
