Cliente cliente = new Cliente("Cristian Delgado", 1132323, "michelo", "hola@gmail.com", "si");
Console.WriteLine("Datos cliente: " + cliente);

public struct Cliente
{
    public Cliente(string nombreCompleto, int telefono, string direccion, string email, string clientenuevo)
    {
        X = nombreCompleto;
        Y = telefono;
        Z = direccion;
        B = email;
        C = clientenuevo;
    }
    public string X { get; }
    public int Y { get; }
    public string Z { get; }
    public string B{ get; }
    public string C { get; }

    public override string ToString() => $"(Nombre completo: {X}, Telefono: {Y}, Dirección: {Z}, Email: {B}, Cliente nuevo?: {C})";
}
