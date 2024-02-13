using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{
    /*[SerializeField] TMP_InputField yearInput;
    [SerializeField] TMP_Text carYearTxt;
    [SerializeField] TMP_Text carMakeTxt;
    [SerializeField] TMP_InputField carMakeInput;*/

    private void Start()
    {
       

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log(testCar.IncreaseSpeed());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log(testCar.DecreaseSpeed());
        }
    }
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
                if (value >= 1886 && value <=2024 )
                {
                   
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
    
    
    public void OnClickTakeYear()
    {
 
            Debug.Log("Click");
       
            /*testCar.Year = int.Parse(yearInput.text);
            carYearTxt.text = carOne.Year.ToString();*/
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void OnClickTakeMake()
    {
        Debug.Log("Click");

    }
    
    
}
