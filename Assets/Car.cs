



public class Car 
{
   
       private int _year;
       private string _make;
       private int _maxSpeed = 100;
       private int _currentSpeed = 0;
      
        public Car(int year, string make) 
        {
            /*_year = year;
            _make = make;*/
            Year = year;
            Make = make;
         
        }  
        public int Year
        {
            get
            {
                return _year;
                
            }
            set
            {
                if (value >= 1886 && value <=2024 )
                {
                   
                     _year = value;
                }
            else if (value < 1886)
            {

                value = 1886;
                _year = value;

            }
             else if(value > 2024)
            {
                value = 2024;
                _year = value;

            }
           
                
            }
        }
    public string Make
    {
        get
        {
            return _make;
        }
        set
        {

            if (value != "")
            {
                _make = value;
            }
            else
            {
                _make = "";
            }
        }
    }
    public int IncreaseSpeed()
        {
           if(_currentSpeed < _maxSpeed)
            {
                return _currentSpeed += 10;
            }
            return _currentSpeed;
        }
        public int DecreaseSpeed()
        {
            if (_currentSpeed > 0)
            {
                return _currentSpeed -= 10;
            }
            return _currentSpeed;
        }
 
    
}
