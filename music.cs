var notas = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" }; // asigar forma para tener Bemoles
var patron = new string[] { "T", "T", "1/2", "T", "T", "T", "1/2" }; // Variable
var escala = new List<string>(); // Almacena la Escala

int cont = 0;
for (int i = 0; i < patron.Length; i++)
{
	if (patron[i] == "T")
    {
		cont += 2;
		escala.Add(notas[cont]);
     } else if (patron[i] == "1/2")
    {
		cont += 1;
		escala.Add(notas[cont]);
    }
}