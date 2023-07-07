namespace InterfaceExercise;

public class Truck : IVehicle
{
    public bool HighHorsePower { get; set; }
    public bool HasRearCover { get; set; }
    //Inherited
    public bool HasWheels { get; set; }
    public bool HasFrame { get; set; }
    public bool IsDriveable { get; set; }
    public bool Exists { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
}