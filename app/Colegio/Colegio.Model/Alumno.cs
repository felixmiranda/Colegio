using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Model
{
    [Table("Alumno")]
    public class Alumno
    {
        public Alumno()
        {
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }


        public virtual ICollection<Curso> Curso { get; set; }

        public List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            try
            {
                using (var context = new colegioContext())
                {
                    alumnos = context.Alumno.ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return alumnos;
        }
    }
}
