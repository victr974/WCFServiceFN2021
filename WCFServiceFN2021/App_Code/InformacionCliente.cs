using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
[DataContract]
/// <summary>
/// Descripción breve de InformacionCliente
/// </summary>
public class InformacionCliente
{
    public InformacionCliente()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public string NoCorrelativo { get; set; }
    [DataMember]
    public string NoContador { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public int Saldo { get; set; }
    [DataMember]
    public int Deuda { get; set; }

}