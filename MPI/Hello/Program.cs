using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPI;

// ************************************************************************
// Practica 05
// Jose Pupiales, Juan Noboa, Angel Solis
// Fecha de realización: 07/01/2022
// Fecha de entrega: 14/01/2022
// **************************************************************
// Resultados:
// 1. USO BASICO DE MPI* Se ejecutó el programa HELLO en donde se probó con valores de 4, 8 y 16 procesos, al realizar esto se observó
// que se los proceso se ejecutan desde 0 a n-1 del total de procesos y que dichos procesos no se ejecutaron
// en orden sino son aleatorios y por ende los resultados son diferentes.

// 2. CÁLCULO DE PI* Se pudo observar que al ejecutar con varios valores de n, el valor de pi va cambiando, adicionalmente 
// se pudo comprobar que el tiempo de ejecución aumenta a medida que aumenta el valor n. Por último se usó un valor de n=290
// y el resultado fue de 5.78458, lo que es un valor diferente al valor que conocemos de PI, esto se debe a que el valor de n es muy grande 
// y por lo tanto el programa no pudo ejecutarse adecuadamente.

// 4. RING* Se ejecuta el programa RING mediante el comando  mpiexec -np 1 Ring.exe, de modo que se genera un error y dse despliega el mensaje
// de que se necesita al menos dos procesos para correr el ejemplo RUN, al ejecutar con el comando  mpiexec -np 4 Ring.exe el progrma se ejecuta 
// y se despliega el mensaje Hello Word y a continuacion los números del 1 al n-1 donde n es el valor ingresado en el comando para la ejecucion,
// y ademas contiene el 0 al ultimo separados por una coma. al aumentar el valor simplemente se despliegan mas numeros hasta el valor de n-1.

// **************************************************************

// Conclusiones:
// *. En la practica se pudo ver como MPI es una técnica usada generalmente en programación concurrente pues aporta sincronización
// entre procesos y permite la exclusión mutua.
// *. MPI nos permite realizar el inicio, gestión y finalización de los distintos procesos, y es por esta razón que con el uso de MPI
// podemos realizar la implementación de procesos secuenciales, los cuales realizan actividades programadas, además como se pudo 
// apreciar, MPI permite realizar la gestión del orden de ejecución de los procesos, esto con la finalidad de lograr un mejor resultado
// al mandar a correr los distintos códigos. 
// *. Se pudo concluir que en el programa de PI al aumentar el número de n a un valor mayor a 290, el resultado que nos muestra el programa
// es diferente al valor de PI ya que rank permite realizar cada proceso y al utilizar un valor grande estos 
// procesos se van a demorar demasiado.

// *. Mediante la practica, se puede concluir que los progrmas desarrollados con MPI tienen mas opciones de comunicacion punto a punto 
// y son mas grandes en multiprocesos.
// *. Con MPI, se puede ejecutar de distinta forma los programas, ya que como se pudo ver en el caso de RING al ejecutar desde
// Visual el programa no se podia obtener otro resultado y por otra parte al ejecutar en la ventana de comandos de windows se puede
// aumentar el valor de n para aumentar el numero de procesos y obtener una mejor visualizacion de los resultados.
// *. Con MPI el número de procesos requeridos se asigna antes de la ejecución del programa, y
// no se crean procesos adicionales mientras la aplicación se ejecuta.

// *******************************************************

// Recomendaciones:
// *Se recomienda instalar en todas los proyectos la biblioteca de MPI.NET para poder usar sus funciones
//  caso contrario no se podra ejecutar los programas y nos saldra error de compilacion.
// *Al momento de ejecutar cada uno de los proyectos en Visual se recomienda utilizar las teclas Ctrl+F5 
// ya que al momento de precionar el boton inicio el programa se ejecuta pero no se puede observar resultados
// ya que la consola se cierra rapidamente.

namespace Hello
{
	class Program
	{
		static void Main(string[] args)
		{
			using (new MPI.Environment(ref args))
			{
				//Se imprime un saludo con el numero de proceso y el rank.
				Console.WriteLine("Hello, from process number "
				+ Communicator.world.Rank + " of "
			   + Communicator.world.Size);

			}
		}
	}
}
