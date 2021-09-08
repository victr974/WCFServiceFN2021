using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public string AgregarCliente(string JSON)
    {
        Cliente ObjCliente = new Cliente();
        return ObjCliente.AgregarCliente(JSON);

    }

    public List<Cliente> ConsultarClientes()
    {
        Cliente cliente = new Cliente();
        return cliente.ConsultarClientes();
    }

    public Respuesta RealirzaPago(String NoCorrelativo, int monto)
    {
        opCliente op = new opCliente();
        return op.RealizarPago(NoCorrelativo, monto);
    }

    //public Cliente SolicitarCamposJson(string NoCorrelativo)
    //{ 
    //SolicitarCampoCliente cliente = new SolicitarCampoCliente();
    //  Cliente respuesta = cliente.SolicitarCamposJson(json, NoCorrelativo);
    //  if (respuesta != null && !string.IsNullOrEmpty(respuesta.NoCorrelativo))
    //  {
    //      return respuesta;
    //  }
    //  else
    // {
    //      respuesta.NoCorrelativo = "error al buscar el NoCorrelativo";
    //      return respuesta;
    //  }

    //}
}
