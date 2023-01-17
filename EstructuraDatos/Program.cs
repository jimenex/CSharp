using System.Security.Cryptography.X509Certificates;
using System.Transactions;

DatosCliente stDatosCliente = new DatosCliente("Jimenex", "2175007","Buenos Aires","v@com",true);
Console.WriteLine(stDatosCliente);

public struct DatosCliente
{
    public DatosCliente(string nombreCompleto, 
                        string telefono,
                        string dirección,
                        string email,
                        bool esNuevo)
    {
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Dirección = dirección;
        Email = email;
        EsNuevo = esNuevo;
    }

    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public string Dirección { get; set; }
    public string Email { get; set; }
    public bool EsNuevo { get; set; }

    public override string ToString()
    {
        return $"Nombre Completo: {NombreCompleto}\n Telefono: {Telefono}\n Dirección: {Dirección}\n Correo: {Email}\n NuevoCliente: {EsNuevo}";
    }
}




