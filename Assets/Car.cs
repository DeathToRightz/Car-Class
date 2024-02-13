using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
public class Car : MonoBehaviour
{
    [SerializeField] TMP_InputField _yearInput;
    [SerializeField] TMP_Text carYearTxt;
    public class TypeofCar
    {
        
       private int _year;
       private string _make;
       private int _maxSpeed = 100;
       private int _currentSpeed = 0;
      
        public TypeofCar(int year, string make) 
        {
            _year = year;
            _make = make;  
        }  
        public int Year
        {
            get
            {
                
                return _year;
            }
            set
            {
               
                _year = value;
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
                _make = value;
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
    TypeofCar carOne = new TypeofCar(2001, "Nissan");
   
    private void Start()
    {
       
        //carOne.Make = "Toyota";     
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(carOne.IncreaseSpeed());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log(carOne.DecreaseSpeed());
        }
    }
    public void ShowyearButton()
    {
        carOne.Year = int.Parse(_yearInput.text);
        carYearTxt.text = carOne.Year.ToString();
    }
}
