namespace Vehicles
{

    public class Car
    {
        private int _year;
        private string _make;
        private int _speed;

        private int _tirePressure;

        public Car()
        {
            this._year = 1994;
            this._make = "Ford";
            this._speed = 0;
        }

        public Car(int year, string make, int speed)
        {
            this._year = year;
            this._make = make;
            this._speed = speed;
        }

        public string Make
        {
            get { 
                return _make; 
                }
            
            set { 
                _make = value; 
                }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void DriveFaster(int increment)
        {
            _speed += increment;

        }
        public void DriveSlower(int increment)
        {
            _speed -= increment;
        }


        public string GetMake()
        {
            return _make;
        }

         public void SetMake(string make)
        {
            _make = make;
        }

        public int GetTirePressure()
        {
            return _tirePressure;    
        }

    }
}