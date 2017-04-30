using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad1
{
    public class ViewModel
    {
        public Guid Id { get; set; }
        public string Baslık { get; set; }
        public string Not { get; set; }
        public int Oncelik { get; set; }
    }
}
