//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seguro.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARCA
    {
        public MARCA()
        {
            this.MODELO = new HashSet<MODELO>();
        }
    
        public string ID_MARCA { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<MODELO> MODELO { get; set; }
    }
}
