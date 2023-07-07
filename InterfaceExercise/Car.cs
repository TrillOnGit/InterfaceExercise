namespace InterfaceExercise;

public class Car : IVehicle
{
    public string CuteBeepSound { get; set; }
    public bool AllWheelDrivable { get; set; }
    //Inherited
    public bool HasWheels { get; set; }
    public bool HasFrame { get; set; }
    public bool IsDriveable { get; set; }
    public bool Exists { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
}