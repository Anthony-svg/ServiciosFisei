using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;

namespace WcfServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "NuevoParticipante?CI={CI}&Contrasenia={Contrasenia}" +
        "&Nombre={Nombre}&Apellido={Apellido}&Telefono={Telefono}&Correo={Correo}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        Participantes NuevoParticipante(string CI, string Contrasenia, string Nombre, string Apellido, string Telefono, string Correo);

        [OperationContract]
        [WebInvoke(UriTemplate = "IniciarSesionParticipante?CI={usuario}&Contrasenia={clave}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        bool IniciarSesionParticipante(string usuario, string clave);


        [OperationContract]
        [WebInvoke(UriTemplate = "DevolverEventos", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        List<Evento> DevolverEventos();

        [OperationContract]
        [WebInvoke(UriTemplate = "IniciarSesionAdministrador?CI={usuario}&Contrasenia={clave}", Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        bool IniciarSesionAdministrador(string usuario, string clave);
    }

}
