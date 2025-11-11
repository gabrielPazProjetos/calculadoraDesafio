namespace CalculadoraTDD
{
    public class Operacao
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
        public string Operador { get; set; }
        public int Resultado { get; set; }

        public override string ToString()
        {
            return $"{PrimeiroNumero} {Operador} {SegundoNumero} = {Resultado}";
        }
    }
}
