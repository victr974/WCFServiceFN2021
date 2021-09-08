using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{
	[OperationContract]
	string AgregarCliente(string JSON);

	[OperationContract]
	List<Cliente> ConsultarClientes();

	[OperationContract]
	Respuesta RealirzaPago(String NoCorrelativo, int monto);

	//[OperationContract]
	//Cliente SolicitarCamposJson( string NoCorrelativo);


}

 
