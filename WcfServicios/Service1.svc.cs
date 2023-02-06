using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using LogicaNegocio;


namespace WcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Participantes NuevoParticipante(string CI, string Contrasenia, string Nombre, string Apellido, string Telefono, string Correo)
        {
            Participantes pa= new Participantes();
            pa.CI = CI;
            pa.Contrasenia = Contrasenia;
            pa.Nombre = Nombre;
            pa.Apellido = Apellido;
            pa.Telefono = Telefono;
            pa.Correo = Correo;
            return ParticipantesLogica.Nuevo(pa);
        }

        public bool IniciarSesionParticipante(string usuario, string clave)
        {
            return ParticipantesLogica.IniciarSesionParticipante(usuario, clave);
        }

        public  List<Evento> DevolverEventos()
        {
            return EventoLogica.DevolverEventos();
        }

        public bool IniciarSesionAdministrador(string usuario, string clave)
        {
            return AdministradoresLogica.IniciarSesionAdministrador(usuario, clave);
        }
    }
}
