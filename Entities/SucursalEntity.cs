namespace PracticaDBMigrations.Entities
{
    public class SucursalEntity
{
    public Guid Id { get; set; }

    public string? Name { get; set; } = null;

    public string? Location { get; set; } = null;

    public int CantidadEmpleados { get; set; }


}

}
