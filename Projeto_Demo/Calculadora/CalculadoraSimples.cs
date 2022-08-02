namespace Calculadora
{
    public class CalculadoraSimples
    {
        /* Método para Adicionar*/
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        /*Método para Multiplicar*/
        public int Multi(int number1, int number2)
        {
            // Para fins de demo (bug) => return number1 * number2
            // return number1 + number2;

            return number1 * number2;
        }

        public int Div(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}