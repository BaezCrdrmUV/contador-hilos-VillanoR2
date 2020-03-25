using System;
using System.Threading;

namespace contador_hilos_VillanoR2 {

    class Program {
        static void Main (string[] args) {
            String entrada = "";
            int contador = 0;
            Console.WriteLine ("Ingresa el boton 1 para iniciar el contador automatico de hilos: \t Para detener el programa precione ctrl + c");
            Console.WriteLine ("Ingresa el boton 2 para iniciar el contador manual de hilos:");
            do {
                
                entrada = Console.ReadLine ();

                if (entrada == "1") {
                    ThreadStart iniciarHilo = new ThreadStart (contadorAuto);
                    Thread hiloAuto = new Thread (iniciarHilo);
                    hiloAuto.Start ();

                } else if (entrada == "2") {

                    String Manual = "";
                    if (contador <= 100) {
                        Manual = contador.ToString ();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine ("Contador manual");
                        System.Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine ("Hilo: " + Manual);
                        contador++;
                        Thread.Sleep (1000);
                    }
                }
            } while (entrada != "1" || entrada != "2");

        }

        public static void contadorAuto () {
            String TextAutomatico = "";
            int i;
            for (i = 0; i <= 100; i++) {
                TextAutomatico = i.ToString ();
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine ("Contador Automatico");
                System.Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine ("Hilo :" + TextAutomatico);
                Thread.Sleep (1000);
            }
        }
    }
}