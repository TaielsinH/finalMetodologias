using System;
namespace MetodologíasDeProgramaciónI
{
	public abstract class AlumnoDecorator : IAlumno
	{
		protected IAlumno componente;
		public int ResponderPregunta(int pregunta)
		{
			return componente.ResponderPregunta(pregunta);
		}
		public void setCalificacion(int Valor)
		{
			componente.setCalificacion(Valor);
		}
		public int getLegajo()
		{
			return componente.getLegajo();
		}
		public int getCalificacion()
		{
			return componente.getCalificacion();
		}
		public virtual string mostrarCalificacion()
		{
			return componente.mostrarCalificacion();
		}
		public string getNombre()
		{
			return componente.getNombre();
		}
		public void setNombre(string name)
		{
			componente.setNombre(name);
		}
        public bool sosIgual(Comparable c)
		{
			return componente.sosIgual(c);
		}
        public bool sosMenor(Comparable c)
		{
			return componente.sosMenor(c);
		}
        public bool sosMayor(Comparable c)
		{
			return componente.sosMayor(c);
		}
    }
	public class AlumnoDecoratorLegajo : AlumnoDecorator
	{

		public AlumnoDecoratorLegajo(IAlumno componente)
		{
			this.componente = componente;
		}
		public override string mostrarCalificacion()
		{
			string[] partes = componente.mostrarCalificacion().Split(componente.getNombre());
			string resultado = componente.mostrarCalificacion();
			return componente.getNombre()+ " (" +componente.getLegajo() +")" +"     " + partes[1];
		}
	}
	public class AlumnoDecoratorCasos : AlumnoDecorator
	{
		public AlumnoDecoratorCasos(IAlumno componente)
		{
			this.componente = componente;
		}
		public string Casos()
		{
			string caso;
			int calificacion = componente.getCalificacion();
			if (calificacion < 4)
				caso = "DESAPROBADO";
			else if (calificacion > 4 && calificacion < 7)
				caso = "APROBADO";
			else
				caso = "PROMOCIONADO";
			return caso;
		}
		public override string mostrarCalificacion()
		{
			string caso = Casos();
			return componente.mostrarCalificacion() + "(" + caso + ")";
		}
	}
	public class AlumnoDecoratorLetras : AlumnoDecorator
	{
		public AlumnoDecoratorLetras(IAlumno componente)
		{
			this.componente = componente;
		}
		
		public string letras()
		{
			string resultado;
			int calificacion = componente.getCalificacion();
			switch (calificacion)
			{
				case 0:
					resultado = "CERO";
					break;
				case 1:
					resultado = "UNO";
					break;
				case 2:
					resultado = "DOS";
					break;
				case 3:
					resultado = "TRES";
					break;
				case 4:
					resultado = "CUATRO";
					break;
				case 5:
					resultado = "CINCO";
					break;
				case 6:
					resultado = "SEIS";
					break;
				case 7:
					resultado = "SIETE";
					break;
				case 8:
					resultado = "OCHO";
					break;
				case 9:
					resultado = "NUEVE";
					break;
				case 10:
					resultado = "DIEZ";
                    break;
				default:
					resultado = "ERROR";
					break;
					
			}
			return resultado;
		}
		public override string mostrarCalificacion()
		{
			string l = letras();
			return componente.mostrarCalificacion() + "(" + l + ")";
		}
	}
    public class AlumnoDecoratorRecuadro : AlumnoDecorator
    {
        public AlumnoDecoratorRecuadro(IAlumno componente)
        {
            this.componente = componente;
        }
        public override string mostrarCalificacion()
        {
            int countChar = componente.mostrarCalificacion().Length;
            return new string('*', countChar + 6) + "\n*  " + base.mostrarCalificacion() + "  *\n" + new string('*', countChar + 6);

        }
    }
}
