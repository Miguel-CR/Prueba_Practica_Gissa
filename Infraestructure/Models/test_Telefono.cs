//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class test_Telefono
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public string UsuarioCedula { get; set; }
    
        public virtual test_Usuario test_Usuario { get; set; }
    }
}