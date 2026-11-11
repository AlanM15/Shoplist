using System;
using System.Collections.Generic;
using System.Text;

namespace Shoplist.Maui.Models
{
    public class ShopListItem
    {
        
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public bool Comprado { get; set; }
    }
}
