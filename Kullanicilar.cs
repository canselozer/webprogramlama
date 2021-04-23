using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Is
{
    public class Kullanicilar
    {
        public List<Proje.Veri.tbl_Kullanicilar> Listele()
        {
            Proje.Veri.PERSONEL_TAKIPEntities ent = new Veri.PERSONEL_TAKIPEntities();
            var kullaniciliste = ent.tbl_Kullanicilar.ToList();
            return kullaniciliste;

        }
        public List<Proje.Veri.tbl_Proje> ListeleProje()
        {
            Proje.Veri.PERSONEL_TAKIPEntities ent1 = new Veri.PERSONEL_TAKIPEntities();
            var projelistele = ent1.tbl_Proje.ToList();
            return projelistele;
        }
    }
}
