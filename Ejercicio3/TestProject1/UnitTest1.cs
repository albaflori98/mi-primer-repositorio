using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarImpares;
using System.IO;
using System;

namespace TestProject1 {
    [TestClass]
    
    public class UnitTest1 {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        public void TestMethod1() {
            //No entra en el bucle
            //Datos

            string datos = "0";
            string resultadoEsperado = "La suma de los numeros pares es 0\nLa suma de los numeros impares es 0";
            StringWriter sw = new StringWriter();
            StringReader sr = new StringReader(datos);
            Console.SetIn(sr);
            Console.SetOut(sw);

            //Ejecución
            SumaImpares.SumarParesEImpares();

            //Recogemos la salida del programa en la consola 
            string salida = sw.ToString().Trim();
            //lo separamos en lineas y lo guardamos en un array
            string[] lineasDeSalida = salida.Split("\r\n");
            string resultadoFinal = lineasDeSalida[lineasDeSalida.Length - 2] + "\n" + lineasDeSalida[lineasDeSalida.Length - 1];

            //Muestro los resultados en la propia prueba
            TestContext.WriteLine($"La salida esperada del programa es: \n{resultadoEsperado}");
            TestContext.WriteLine($"La salida del programa es: \n{resultadoFinal}");


            //Evaluar la salida
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }
        [TestMethod]
        public void TestMethod2() {
            //Entra una vez en el bucle
            //Datos
            string datos = "1\n0";
            string resultadoEsperado = "La suma de los numeros pares es 0\nLa suma de los numeros impares es 1";
            StringWriter sw = new StringWriter();
            StringReader sr = new StringReader(datos);
            Console.SetIn(sr);
            Console.SetOut(sw);

            //Ejecución
            SumaImpares.SumarParesEImpares();

            //Recogemos la salida del programa en la consola 
            string salida = sw.ToString().Trim();
            string[] lineasDeSalida = salida.Split("\r\n");
            string resultadoFinal = lineasDeSalida[lineasDeSalida.Length - 2] + "\n" + lineasDeSalida[lineasDeSalida.Length - 1];

            //Muestro los resultados en la propia prueba
            TestContext.WriteLine($"La salida esperada del programa es: \n{resultadoEsperado}");
            TestContext.WriteLine($"La salida del programa es: \n{resultadoFinal}");

            //Evaluar la salida
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void TestMethod3() {
            //Entra dos veces en el bucle
            //Datos

            string datos = "1\n4\n0";
            string resultadoEsperado = "La suma de los numeros pares es 4\nLa suma de los numeros impares es 1";
            StringWriter sw = new StringWriter();
            StringReader sr = new StringReader(datos);
            Console.SetIn(sr);
            Console.SetOut(sw);

            //Ejecución
            SumaImpares.SumarParesEImpares();

            //Recogemos la salida del programa en la consola 
            string salida = sw.ToString().Trim();
            string[] lineasDeSalida = salida.Split("\r\n");
            string resultadoFinal = lineasDeSalida[lineasDeSalida.Length - 2] + "\n" + lineasDeSalida[lineasDeSalida.Length - 1];

            //Muestro los resultados en la propia prueba
            TestContext.WriteLine($"La salida esperada del programa es: \n{resultadoEsperado}");
            TestContext.WriteLine($"La salida del programa es: \n{resultadoFinal}");
            
            //Evaluar la salida
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }

        [TestMethod]
        public void TestMethod4() {
            //Entra varias veces en el bucle
            //Datos

            string datos = "8\n7\n3\n0";
            string resultadoEsperado = "La suma de los numeros pares es 8\nLa suma de los numeros impares es 10";
            StringWriter sw = new StringWriter();
            StringReader sr = new StringReader(datos);
            Console.SetIn(sr);
            Console.SetOut(sw);

            //Ejecución
            SumaImpares.SumarParesEImpares();

            //Recogemos la salida del programa en la consola 
            string salida = sw.ToString().Trim();
            string[] lineasDeSalida = salida.Split("\r\n");
            string resultadoFinal = lineasDeSalida[lineasDeSalida.Length - 2] + "\n" + lineasDeSalida[lineasDeSalida.Length - 1];

            //Muestro los resultados en la propia prueba
            TestContext.WriteLine($"La salida esperada del programa es: \n{resultadoEsperado}");
            TestContext.WriteLine($"La salida del programa es: \n{resultadoFinal}");
            

            //Evaluar la salida
            Assert.AreEqual(resultadoEsperado, resultadoFinal);
        }
    }
}
