class Cliente
{
    private string nombre;
    private int monto;

    public Cliente(string nom)
    {
        nombre = nom;
        monto = 0;
    }

    public void Depositar(int m)
    {
        monto = monto + m;
    }

    public void Retirar(int m)
    {
        monto = monto - m;
    }

    public int ObtenerSaldo()
    {
        return monto;
    }

    public void Imprimir()
    {
        Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
    }
}
