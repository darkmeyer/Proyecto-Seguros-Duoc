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
    
    public partial class COBERTURA
    {
        public COBERTURA()
        {
            this.SEGURO = new HashSet<SEGURO>();
        }
    
        public string ID_COBERTURA { get; set; }
        public string PERDIDA_TOTAL { get; set; }
        public string DANO_TERCEROS { get; set; }
    
        public virtual ICollection<SEGURO> SEGURO { get; set; }
    }
}
