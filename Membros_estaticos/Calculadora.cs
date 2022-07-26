namespace Membros_estaticos
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return raio * 2.0 * Pi;
        }
        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
