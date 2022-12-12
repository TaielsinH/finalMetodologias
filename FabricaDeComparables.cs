using System;
namespace MetodologíasDeProgramaciónI
{
    public abstract class FabricaDeComparables
    {
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica;
            if (opcion == 1)
            {
                GeneradorDeDatosAleatorios num = new GeneradorDeDatosAleatorios();
                fabrica = new FabricaDeNumeros();
            }
            else if (opcion == 2)
            {
                GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
                fabrica = new FabricaDeAlumnos();
            }
            else if (opcion == 3)
            {
                fabrica = new FabricaDeVendedores();
            }
            else if (opcion == 4)
            {
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
            }
            else if (opcion == 5)
            {
                fabrica = new FabricaDeProxys();
            }
            else
            {
                fabrica = new FabricaDeNumeros();
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica;
            if (opcion == 1)
            {
                fabrica = new FabricaDeNumeros();
            }
            else if (opcion == 2)
            {
                fabrica = new FabricaDeAlumnos();
            }
            else if (opcion == 3)
            {
                fabrica = new FabricaDeVendedores();
            }
            else if (opcion == 4)
            {
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
            }
            else
            {
                fabrica = new FabricaDeNumeros();
            }
            return fabrica.crearPorTeclado();
        }

    }
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            string nombre = aleatorio.stringAleatorio(5);
            int dni = aleatorio.numeroAleatorio(100000000);
            int sueldoBasico = aleatorio.numeroAleatorio(1000000);
            Vendedor ven = new Vendedor(nombre, dni, sueldoBasico);
            return ven;
        }
        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del vendedor: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el dni del vendedor: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("ingrese el sueldo basico: ");
            int sueldoBasico = int.Parse(Console.ReadLine());

            Vendedor ven = new Vendedor(nombre, dni, sueldoBasico);
            return ven;
        }
    }
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            return new Numero(aleatorio.numeroAleatorio(1000000));
        }
        public override Comparable crearPorTeclado()
        {
            LectorDeDatos num = new LectorDeDatos();
            Numero numero = new Numero(num.NumeroPorTeclado());
            return numero;
        }
    }
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            string nombre = aleatorio.stringAleatorio(8);
            int dni = aleatorio.numeroAleatorio(10000000);
            int legajo = aleatorio.numeroAleatorio(100000);
            int promedio = aleatorio.numeroAleatorio(10);

            Alumno al = new Alumno(nombre, dni, legajo, promedio);
            return al;
        }
        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de legajo: ");
            int legajo = int.Parse(Console.ReadLine());
            Console.Write("INgrese el promedio del alumno: ");
            int promedio = int.Parse(Console.ReadLine());

            Alumno al = new Alumno(nombre, dni, legajo, promedio);
            return al;
        }
    }
    public class FabricaDeProxys : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            string nombre = aleatorio.stringAleatorio(8);
            ProxyAlumno prox = new ProxyAlumno(nombre);
            return (Comparable)prox;
        }
        public override Comparable crearPorTeclado()
        {
            string nombre = Console.ReadLine();
            ProxyAlumno prox = new ProxyAlumno(nombre);
            return prox;
        }
    }
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            string nombre = aleatorio.stringAleatorio(8);
            int dni = aleatorio.numeroAleatorio(10000000);
            int legajo = aleatorio.numeroAleatorio(100000);
            int promedio = aleatorio.numeroAleatorio(10);

            AlumnoMuyEstudioso al = new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
            return al;
        }
        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de legajo: ");
            int legajo = int.Parse(Console.ReadLine());
            Console.Write("INgrese el promedio del alumno: ");
            int promedio = int.Parse(Console.ReadLine());

            AlumnoMuyEstudioso al = new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
            return al;
        }
    }


}

