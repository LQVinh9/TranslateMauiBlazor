using System.Globalization;
using TranslateMauiBlazor.Interfaces;
using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Services
{
    internal class CultureService : ICultureService
    {
        public List<CultureModel> GetListCulture()
        {
            List<CultureModel> list = new();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                string specName = "(none)";
                try { specName = CultureInfo.CreateSpecificCulture(ci.Name).Name; } catch { }
                CultureModel cultureModel = new()
                {
                    Name = ci.Name,
                    SpecName = specName,
                    EnglishName = ci.EnglishName
                };
                list.Add(cultureModel);
            }

            return list.Where(e => e.Name.Length == 2).OrderBy(e => e.Name).ToList();
        }
    }
}
