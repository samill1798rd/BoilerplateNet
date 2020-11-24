using Model.Entidades;
using System.Collections.Generic;

namespace Model
{
    public class Usuario : AEntity<int>
    {
        public Usuario()
        {
            Iglesias = new List<Iglesia>();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public virtual ICollection<Iglesia> Iglesias { get; set; }
    }
}
