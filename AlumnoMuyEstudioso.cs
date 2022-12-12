using System;
namespace MetodologíasDeProgramaciónI
{
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string n, int d, int legajo, float promedio) : base(n, d, legajo, promedio)
		{
		}
		public override int ResponderPregunta(int pregunta)
		{
			return pregunta % 3;
		}
	}
}
