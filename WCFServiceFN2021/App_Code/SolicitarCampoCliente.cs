using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SolicitarCampoCliente
/// </summary>
public class SolicitarCampoCliente
{
    public SolicitarCampoCliente()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public Cliente SolicitarCamposJson(string JSON, string NoCorrelativo)
    {
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        clientes = JsonConvert.DeserializeObject<List<Cliente>>(JSON);

        foreach (Cliente item in clientes)
        {
            if (item.NoCorrelativo == NoCorrelativo)
            {
                cliente = item;
            }
        }

        return cliente;
    }

}