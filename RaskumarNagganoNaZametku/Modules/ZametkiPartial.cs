using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskumarNagganoNaZametku.Modules
{
    internal class ZametkiPartial
    {
        public void ObnovitZametki()
        {
            var zametki = App.Context.zametki.ToList();

            //zametki = zametki.Where(p => p.id_zametki.Contains(zametki).ToList();
            //LV.ItemsSource = devices;
        }
    }
}
