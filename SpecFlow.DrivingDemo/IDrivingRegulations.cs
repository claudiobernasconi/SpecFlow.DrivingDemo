namespace SpecFlow.DrivingDemo
{
    public interface IDrivingRegulations
    {
        bool IsAllowedToDrive(Person person, Country country);
    }
}
