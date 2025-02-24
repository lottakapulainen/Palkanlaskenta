﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovellusEsim1
{
    //dataluokat
    record Työntekijä(string PalkkaTieto, string Nimi, string Ennakonpidätys, string Palkanmaksupäivä);
    record Palkkatieto(string Palkkatietoja, Työntekijä Omistaja);

    // hallintaluokka
    class Sovellus
    {
        //listat (huom! p.o. public tallentamista varten)
        
        public List<Palkkatieto> Palkkatieto = new List<Palkkatieto>();
        public List<Työntekijä> Työntekijät = new List<Työntekijä>();
        
        

        /// <summary>
        /// Lisää henkilö
        /// </summary>
        /// <param name="työntekijä">Lisättävä henkilö</param>
        public void LisääTyöntekijä(Työntekijä työntekijä)
        {
            Työntekijät.Add(työntekijä);
        }
        public void PoistaTyöntekijä(Työntekijä työntekijä)
        {
            Työntekijät.Remove(työntekijä);
        }

        public string ListaaTyöntekijät()
        {
            string retval = "";
            foreach (var item in Työntekijät)
            {
                retval += $"{item.PalkkaTieto} {item.Nimi} {item.Ennakonpidätys} {item.Palkanmaksupäivä}\n";
            }
            return retval;
        }
        public string ListaaPalkkapäivät()
        {
            string retval = "";
            foreach (var item in Työntekijät)
            {
                retval += $"{item.Nimi} {item.Palkanmaksupäivä}\n";
            }
            return retval;
        }

    }
}
