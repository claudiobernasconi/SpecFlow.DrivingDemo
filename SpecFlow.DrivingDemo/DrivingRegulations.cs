using System.Collections.Generic;

namespace SpecFlow.DrivingDemo
{
    public class DrivingRegulations : IDrivingRegulations
    {
        private readonly IDictionary<Country, int> _drivingAges;

        public DrivingRegulations()
        {
            _drivingAges = new Dictionary<Country, int>
            {
                { Country.UnitedStates, 16 },
                { Country.Cyprus, 17 },
                { Country.Switzerland, 18 },
                { Country.Germany, 18 }
            };
        }

        public bool IsAllowedToDrive(Person person, Country country)
        {
            return _drivingAges[country] <= person.Age;
        }
    }
}
