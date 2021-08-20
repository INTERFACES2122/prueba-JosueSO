using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_de_Consola
{
    /// <summary>
    /// Clase que representa a un alumno
    /// </summary>
    public class Alumno
    {
        private string cve_unica;
        private string nombres;
        private string apellidos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Alumno() { }

        /// <summary>
        /// Constructor de la clase que asigna información inicial
        /// </summary>
        /// <param name="_cve_unica">Clave única del alumno</param>
        /// <param name="_nombres">Nombre (s) del alumno</param>
        /// <param name="_apellidos">Apellidos del alumno</param>
        public Alumno(string _cve_unica, string _nombres, string _apellidos)
        {
            cve_unica = _cve_unica;
            nombres = _nombres;
            apellidos = _apellidos;
        }

        /// <summary>
        /// Obtiene la información del alumno en una sola variable
        /// </summary>
        /// <returns>Cadena con la información del alumno</returns>
        public string ObtenerInformacion()
        {
            string informacion = "";

            informacion = cve_unica + " - " + nombres + " " + apellidos;

            return informacion;
        }
    }
}
