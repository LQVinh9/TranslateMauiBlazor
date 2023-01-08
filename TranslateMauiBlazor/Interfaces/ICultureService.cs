using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Interfaces
{
    interface ICultureService
    {
        List<CultureModel> GetListCulture();
    }
}
