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
    
    public partial class LIQUIDADOR
    {
        public LIQUIDADOR()
        {
            this.SINIESTRO = new HashSet<SINIESTRO>();
        }
    
        public string ID_LIQUIDADOR { get; set; }
        public string RUT { get; set; }
        public string PASS { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CORREO { get; set; }
        public System.DateTime FECHA_NACIMIENTO { get; set; }
        public string DIRECCION { get; set; }
        public short ID_CIUDAD { get; set; }
    
        public virtual ICollection<SINIESTRO> SINIESTRO { get; set; }
    }
}