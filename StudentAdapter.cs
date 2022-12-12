using System;
using System.Xml.Linq;

namespace MetodologíasDeProgramaciónI
{
	public class StudentAdapter : Student
	{
		private Alumno al;
		public StudentAdapter(Alumno al)
		{
			this.al = al;
		}
		public string getName()
		{
			return al.getNombre();
		}
		public int yourAnswerIs(int question)
		{
			return al.ResponderPregunta(question);
		}
		public void setScore(int score)
		{
			al.setCalificacion(score);
		}
		public string showResult()
		{
           
			return al.mostrarCalificacion();
        }
		public bool equals(Student student)
		{
			return al.sosIgual(((StudentAdapter)student).al);
		}
		public bool lessThan(Student student)
		{
			return al.sosMenor(((StudentAdapter)student).al);
		}
		public bool greaterThan(Student student)
		{
			return al.sosMayor(((StudentAdapter)student).al);
		}

	}
	public class ProxyAdapter : Student
	{
		private ProxyAlumno prox;
		public ProxyAdapter(ProxyAlumno prox)
		{
			this.prox = prox;
		}
        public string getName()
		{
			return prox.getNombre();
		}
        public int yourAnswerIs(int question)
		{
			return prox.ResponderPregunta(question);
		}
        public void setScore(int score)
		{
		}
        public string showResult()
		{
			return prox.mostrarCalificacion();
		}
        public bool equals(Student student)
		{
			return prox.sosIgual((Alumno)student);
		}
        public bool lessThan(Student student)
		{
			return prox.sosMenor((Alumno)student);
		}
        public bool greaterThan(Student student)
		{
			return prox.sosMayor((Alumno)student);
		}
    }
}
