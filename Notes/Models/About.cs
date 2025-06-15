namespace Notes.Models;

internal class About
{
    public string Title { get; set; } = "David Puga";
    public string Message { get; set; } = "Soy estudiante de ingeniería en software, me gusta mucho escuchar música y en mis tiempos libres jugar videojuegos.";
    public string MoreInfoUrl => "https://aka.ms/maui";
    
}