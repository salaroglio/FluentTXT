using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTXT.UnitTest
{
    class ZucchettiMovimentiPagheMap : MapText<ZucchettiMovimentiPaghe>
    {
        /// <summary>
        /// In questo "meraviglioso" mapping uso la funzione SetRuleFor(nome dato a caso) che riceve come parametri 
        /// la funzione per mappare i dati: riceve in entrata una stringa e restituisce l'oggetto con la stringa mappata nel campo della classe
        /// gli altri due parametri sono l'inizio del campo e la sua lunghezza.
        /// </summary>
        public ZucchettiMovimentiPagheMap()
        {
            SetMapFor((_, a) => { a.CodContt = _; return a; }, 0, 1);
            SetMapFor((_, a) => { a.CodDit = _; return a; }, 1, 6);
            SetMapFor((_, a) => { a.CodAttv = _; return a; }, 7, 2);
            SetMapFor((_, a) => { a.CodCenDiCosCont = _; return a; }, 9, 12);
            SetMapFor((_, a) => { a.AAPerdElabn = _; return a; }, 21, 4);
            SetMapFor((_, a) => { a.MMPerdElabn = _; return a; }, 25, 2);
            SetMapFor((_, a) => { a.CodConDare = _; return a; }, 27, 12);
            SetMapFor((_, a) => { a.CodConAve = _; return a; }, 39, 12);
            //SetRuleFor((_, a) => { a.ImpMovm = Convert.ToDecimal(_); return a; }, 51, 11); // qui deve convertire dei decimali... ma poi ci penso
            SetMapFor((_, a) => { a.CodSegImprNegt = _; return a; }, 62, 1);
            SetMapFor((_, a) => { a.CodTipoCaus = _; return a; }, 63, 2);
            SetMapFor((_, a) => { a.DesTipoCaus = _; return a; }, 65, 10);
            SetMapFor((_, a) => { a.CodCaus = _; return a; }, 75, 4);
            SetMapFor((_, a) => { a.DesCaus = _; return a; }, 79, 30);
            SetMapFor((_, a) => { a.DesAnntnUte = _; return a; }, 109, 20);
            SetMapFor((_, a) => { a.CodFiscDit = _; return a; }, 129, 16);
            SetMapFor((_, a) => { a.CodSoggDit = _; return a; }, 145, 8);
            SetMapFor((_, a) => { a.NumDit = _; return a; }, 153, 2);
            SetMapFor((_, a) => { a.CodSoggDipn = _; return a; }, 155, 8);
            SetMapFor((_, a) => { a.NumRappDipn = _; return a; }, 163, 3);
            SetMapFor((_, a) => { a.NumLibMatrDipn = _; return a; }, 166, 6);
            SetMapFor((_, a) => { a.CodTipoDatoRiprn = _; return a; }, 172, 2);
            SetMapFor((_, a) => { a.CodDatoRiprn = _; return a; }, 174, 3);
        }
    }
}
