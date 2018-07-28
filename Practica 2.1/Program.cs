using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			byte numerodemes;
			Console.WriteLine("Digite numero del mes:");
			numerodemes = Convert.ToByte(Console.ReadLine());

			switch (numerodemes)
			{
				case 1: Console.WriteLine("Haz elegido el mes de Enero"); break;
				case 2: Console.WriteLine("Haz elegido el mes de Febrero"); break;
				case 3: Console.WriteLine("Haz elegido el mes de Marzo"); break;
				case 4: Console.WriteLine("Haz elegido el mes de Abril"); break;


				case 5: Console.WriteLine("Haz elegido el mes de Mayo"); break;
				case 6: Console.WriteLine("Haz elegido el mes de Junio"); break;
				case 7: Console.WriteLine("Haz elegido el mes de Julio"); break;
				case 8: Console.WriteLine("Haz elegido el mes de Agosto"); break;
				case 9: Console.WriteLine("Haz elegido el mes de Septiembre"); break;
				case 10: Console.WriteLine("Haz elegido el mes de Optubre"); break;
				case 11: Console.WriteLine("Haz elegido el mes de Nviembre"); break;
				case 12: Console.WriteLine("Haz elegido el mes de Diciembre"); break;
				default: Console.WriteLine("No es un numero de mes"); break;

					
			}
			Console.ReadKey();

		}
	}
}
