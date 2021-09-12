using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tarea2_RegistroDeRoles.Entidades
{
    public class Roles
    {

        [Key]
        public int rolesId { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }
        

        public Roles()
        {
            rolesId = 0;
            fechaCreacion = DateTime.Now;
            descripcion = string.Empty;

        }

    }
}
