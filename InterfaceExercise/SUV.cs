namespace InterfaceExercise;

public class SUV : IVehicle
{
    public int CargoHoldSize { get; set; } //Square inches
    public bool HasSpareOnRear { get; set; }
    //Inherited
    public bool HasWheels { get; set; }
    public bool HasFrame { get; set; }
    public bool IsDriveable { get; set; }
    public bool Exists { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
}