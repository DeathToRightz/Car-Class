//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Logan Cordova
//Section: SGD.213.2172
//Instructor: Professor Sowers
//Date: 02/15/2024
/////////////////////////////////////////////
using TMPro;
using UnityEngine;
//using static Car;
using UnityEngine.SceneManagement;
public class TestCar : MonoBehaviour
    
{   //Text and Input Fields for car's year and make
    [SerializeField] TMP_InputField carYearInput;
    [SerializeField] TMP_Text carYearTxt;
    [SerializeField] TMP_Text carMakeTxt;
    [SerializeField] TMP_InputField carMakeInput;
    [SerializeField] TMP_Text speedText;

    //Make reference to the canvases
    public GameObject yearCanvas,createCanvas,makeCanvas;
    
   //Creates reference Car class variable
    Car newCar;
    void Start()
    {
        //Creates car variable for future use
        newCar = new Car(0000, "thing");
        //Deactivate other canvases
        yearCanvas.SetActive(false);
        createCanvas.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //If the player presses the up or down arrow it starts the function in the car Class and displays the change in speed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up");       
            speedText.text =$"Current Speed {newCar.IncreaseSpeed().ToString()}";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down");          
           speedText.text = $"Current Speed {newCar.DecreaseSpeed().ToString()}";
        }
    }
    //If the player doesn't input a name for the make the button wont activate
    public void OnClickGetMake()
    {
        if(carMakeInput.text == "")
        {
            return;
        }
        //If valid it makes the newCar variable the inputed make and sets the corrisponding panels false
        newCar.Make = carMakeInput.text;       
        makeCanvas.SetActive(false);
        yearCanvas.SetActive(true);
      
    }

    //Gets the year inputed and sets it to the car variable for the year and sets the corrisponding panels false
    public void OnClickGetYear()
    {
     
        newCar.Year = int.Parse(carYearInput.text);   
        yearCanvas.SetActive(false);
        createCanvas.SetActive(true);    

    }
    
    //Creates the car variable using the players inputed values
    public void OClickCreateCar()
    {
        carMakeTxt.text = newCar.Make;
        carYearTxt.text = newCar.Year.ToString();
    }
}
