using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
[DataContract]
/// <summary>
/// Descripción breve de opCliente
/// </summary>
public class opCliente
{
    public opCliente()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public Respuesta RealizarPago(String NoCorrelativo, int monto)
    {
        Respuesta result = new Respuesta();
        InformacionCliente cliente = new InformacionCliente();
        StreamReader archivo = new StreamReader("C:\\ArchivosXML,JSON\\JsonCliente.json");
        //pasar al json al lista de cliente , usar forech 
        forech(cliente item in monto)
        string Json = archivo.ReadToEnd();
        try
        {
            if(cliente.NoCorrelativo==NoCorrelativo)
            {
                if(cliente.Deuda<monto)
                {
                    result.codigo = "0";
                    result.respuesta = "Pago se aplico correctamente. Su saldo pendiente es" + cliente.Saldo + "";

                }

               else if  (cliente.Deuda > monto)
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

        catch(Exception ex)
        {
            result.codigo = "-1";
            result.respuesta = "Exepxion " + ex.Message;

        }
        return result;







    }

 

}