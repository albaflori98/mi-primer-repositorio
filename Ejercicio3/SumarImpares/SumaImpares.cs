using System;

 namespace SumarImpares {
    public class SumaImpares {
        static void Main(string[] args) {
            
        }
        public static void SumarParesEImpares() {
            int numeroIntroducido;
            int sumaPares = 0;
            int sumaImpares = 0;
            do {
                Console.WriteLine("Escribe un número (0 para terminar)");
                numeroIntroducido = int.Parse(Console.ReadLine());
                if (numeroIntroducido != 0) {
                    if (numeroIntroducido % 2 == 0) {
                        sumaPares += numeroIntroducido;
                    }
                    else {
                        sumaImpares += numeroIntroducido;
                    }
                }
            } while (numeroIntroducido != 0);

            Console.WriteLine("La suma de los numeros pares es {0}", sumaPares);
            Console.WriteLine("La suma de los numeros impares es {0}", sumaImpares);
        }
    }
}
