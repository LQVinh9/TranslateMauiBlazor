using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Interfaces
{
    interface ITranslateService
    {
        Task<List<TranslateModel>> TranslateLanguage(string text, string[] languages);
    }
}
