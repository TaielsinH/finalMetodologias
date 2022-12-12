using System;
namespace MetodologíasDeProgramaciónI
{ 
public class Aula
{
		private Teacher teacher;
		public void comenzar()
		{
			teacher = new Teacher();
		}
		public void nuevoAlumno(IAlumno a)
		{
			teacher.goToClass(new StudentAdapter((Alumno)a));
		}
		public void claseLista()
		{
			teacher.teachingAClass();
		}
}
	public interface OrdenEnAula1
	{
		void ejecutar();
	}
	public interface OrdenEnAula2
	{
		void ejecutar(Comparable com);
	}
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
		public void ejecutar(Comparable com)
		{
			aula.nuevoAlumno((IAlumno)com);
		}
	}
	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		public void ejecutar()
		{
			aula.comenzar();
		}
	}
	public class OrdenAulaLlena : OrdenEnAula1
	{
		private Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		public void ejecutar()
		{
			aula.claseLista();
		}
	}
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 orden);
		void setOrdenLlegaAlumno(OrdenEnAula2 orden);
		void setOrdenAulaLlena(OrdenEnAula1 orden);
	}
}
