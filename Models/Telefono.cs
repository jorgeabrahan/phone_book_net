namespace agenda.Models;

public class Telefono
{
  public Guid TelefonoId { get; set; }
  public Guid CodigoAreaId { get; set; }
  public Guid PersonaId { get; set; }
  public string Numero { get; set; } = "";
}
