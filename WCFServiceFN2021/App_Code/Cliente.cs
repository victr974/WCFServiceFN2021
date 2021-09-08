using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
[DataContract]

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    public Cliente()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    [DataMember]
    public string NoCorrelativo { get; set; }
    [DataMember]
    public string NoContador { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Saldo { get; set; }
    [DataMember]
    public string Deuda { get; set; }

    public string AgregarCliente(String JSON)
    {
        string respuestaJSON = "";
        Respuesta result = new Respuesta();
        Cliente cliente = new Cliente();
        string ListaJson = "";
        List<Cliente> listaCliente = new List<Cliente>();
        try
        {

            if (!string.IsNullOrEmpty(JSON))
            {
                cliente = JsonConvert.DeserializeObject<Cliente>(JSON);
                if (File.Exists("C:\\ArchivosXML,JSON\\JsonCliente.json"))
                {
                    StreamReader archivo = new StreamReader("C:\\ArchivosXML,JSON\\JsonCliente.json");
                    ListaJson = archivo.ReadToEnd();
                    archivo.Close();
                    listaCliente = JsonConvert.DeserializeObject<List<Cliente>>(ListaJson);
                    listaCliente.Add(cliente);
                }
                else
                {
                    listaCliente.Add(cliente);

                }


                ListaJson = JsonConvert.SerializeObject(listaCliente);
                System.IO.File.WriteAllText("C:\\ArchivosXML,JSON\\JsonCliente.json", ListaJson);

                if (File.Exists("C:\\ArchivosXML,JSON\\JsonCliente.json"))
                {
                    result.codigo = "0";
                    result.codigo = " Cliente registro con exito";

                }
                else
                {
                    result.codigo = "-1";
                    result.respuesta = "Error al intentar registrar";

                }
            }
            else
            {
                result.codigo = "-1";
                result.respuesta = "Falta la peticion";
            }
        }
        catch (Exception ex)
        {
            result.codigo = "-1";
            result.respuesta = "Exepxion " + ex.Message;

        }
        respuestaJSON = JsonConvert.SerializeObject(result);
        return respuestaJSON;

    }

    public List<Cliente> ConsultarClientes()
    {
        List<Cliente> clientes = new List<Cliente>();
        StreamReader archivo = new StreamReader("C:\\ArchivosXML,JSON\\JsonCliente.json");
        string Json = archivo.ReadToEnd();
        clientes = JsonConvert.DeserializeObject<List<Cliente>>(Json);
        //

        return clientes;
    }

    public Cliente SolicitarCamposJson(string NoCorrelativo)
    {
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        StreamReader archivo = new StreamReader("C:\\ArchivosXML,JSON\\JsonCliente.json");
        string Json = archivo.ReadToEnd();
        clientes = JsonConvert.DeserializeObject<List<Cliente>>(JSON );


        foreach (Cliente item in clientes)
        {
            if (item.NoCorrelativo == NoCorrelativo)
            {  
                ///Medeto realizar pago, 
                cliente = item;/// parametro recibir pago 
                if (cliente.NoCorrelativo == NoCorrelativo)
                {

                    // cliente coorelattivo- validar - aplicar el monto apgar y actualizar el saldo. 
                    //
                    if (cliente.Deuda < monto)
                    {
                        result.codigo = "0";
                        result.respuesta = "Pago se aplico correctamente. Su saldo pendiente es" + cliente.Saldo + "";

                    }

                    else if (cliente.Deuda > monto)
                    {
                        result.codigo = "0";
                        result.respuesta = "Solo debe realizar pr un monto menor o igual" + cliente.Saldo + "";

                    }
                    else if (cliente.Deuda == monto)
                    {
                        result.codigo = "0";
                        result.respuesta = "El pago fue exitosamente" + cliente.Saldo + "";

                    }
                }

                else
                {
                    result.codigo = "-1";
                    result.respuesta = "Error al realizar el pago del servicio";

                }
            }
        }

        return cliente;
    }

}