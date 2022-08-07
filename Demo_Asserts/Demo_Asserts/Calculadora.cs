namespace Demo_Asserts
{
    public class Calculadora
    {
        public int SomarNumerosInteiros(int number1, int number2)
        {
            return number1 + number2;
        }

        public double SomarNumerosDecimais(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Dividir(double number1, double number2)
        {
            if (number1 > 100)
            {
                throw new Exception("por"); // propositos para a demo
            }

            return number1 / number2;
        }
    }
}
