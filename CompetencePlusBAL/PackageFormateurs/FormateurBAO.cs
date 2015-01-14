using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageFormateurs
{
    public class FormateurBAO : FormateurDAO
    {
        public static void Add(Formateur f)
        {
            if (f.Nom != "")
                new FormateurDAO().Add(f);
        }
    }
}
