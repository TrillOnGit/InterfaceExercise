namespace InterfaceExercise;

public interface IVehicle : ICompany
{
    public bool HasWheels { get; set; }
    public bool HasFrame { get; set; }
    public bool IsDriveable { get; set; }
    public bool Exists { get; set; }
}