//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetCenter.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GCP_Mascota
    {
        public GCP_Mascota()
        {
            this.GHA_Hospedaje = new HashSet<GHA_Hospedaje>();
            this.GHA_Reserva = new HashSet<GHA_Reserva>();
        }
    
        public int CodigoMascota { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoRaza { get; set; }
        public string NombreMascota { get; set; }
    
        public virtual GCP_Cliente GCP_Cliente { get; set; }
        public virtual GCP_Raza GCP_Raza { get; set; }
        public virtual ICollection<GHA_Hospedaje> GHA_Hospedaje { get; set; }
        public virtual ICollection<GHA_Reserva> GHA_Reserva { get; set; }
    }
}
