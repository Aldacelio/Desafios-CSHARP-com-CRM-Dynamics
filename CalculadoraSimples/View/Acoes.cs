using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraSimples.View
{
    public class Acoes
    {

        public int X()
        {
            int x = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
            return x;
        }

        public int Y()
        {
            int y = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("A entrada não pode ser nula."));
            return y;
        }

        public int Decidir()
        {
            Console.WriteLine("Digite 0 para encerra e 1 para realizar outra operação: ");
            int cont = int.Parse(Console.ReadLine() ?? throw new Exception());
            return cont;
        }
    }
}