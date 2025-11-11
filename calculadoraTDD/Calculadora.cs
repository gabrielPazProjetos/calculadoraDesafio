public class Calculadora
{
    private List<string> _historico;

    public Calculadora()
    {
        _historico = new List<string>();
    }

    public int Somar(int a, int b)
    {
        int resultado = a + b;
        _historico.Add($"{a} + {b} = {resultado}");
        return resultado;
    }

    // Subtrair, Multiplicar, Dividir com lógica semelhante

    public List<string> Historico()
    {
        return _historico;
    }
}
