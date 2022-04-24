public class Retangulo
{
    public double Altura { get; set; }
    public double Base { get; set; }
    public double Area { get => Base * Altura; }
    public double Perimetro { get => (Base + Altura) * 2; }

    public Retangulo(double altura, double _base)
    {
        Altura = altura;
        Base = _base;
    }
}