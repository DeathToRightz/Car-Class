//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Logan Cordova
//Section: SGD.213.2172
//Instructor: Professor Sowers
//Date: 02/15/2024
/////////////////////////////////////////////
public class Car
{
    //The needed private variables
    private int _year;
    private string _make;
    private int _maxSpeed = 100;
    private int _currentSpeed = 0;

    //The car Instance
    public Car(int year, string make)
    {
        Year = year;
        Make = make;
    }
    // Public property that gets the year of the car
    public int Year
    {
        get
        {
            return _year;

        }
        set
        {
            //If the year of the car falls below or above the year range it will force it to be the minumum or maximum range.
            if (value >= 1886 && value <= 2024)
            {
                _year = value;
            }
            else if (value < 1886)
            {
                value = 1886;
                _year = value;
            }
            else if (value > 2024)
            {
                value = 2024;
                _year = value;
            }
        }
    }
    //Public property that gets make of the car
    public string Make
    {
        get
        {
            return _make;
        }
        set
        {
            _make = value;
        }
    }
    //Increases the speed of the car and will stop it before it reaches the max
    public int IncreaseSpeed()
    {
        if (_currentSpeed < _maxSpeed)
        {
            return _currentSpeed += 10;
        }
        return _currentSpeed;
    }
    //Decreases the speed of the car and will stop it before it reaches below 0
    public int DecreaseSpeed()
    {
        if (_currentSpeed > 0)
        {
            return _currentSpeed -= 10;
        }
        return _currentSpeed;
    }


}
