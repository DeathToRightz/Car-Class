using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using static Car;
using UnityEngine.SceneManagement;
public class TestCar : MonoBehaviour
{
    [SerializeField] TMP_InputField carYearInput;
    [SerializeField] TMP_Text carYearTxt;
    [SerializeField] TMP_Text carMakeTxt;
    [SerializeField] TMP_InputField carMakeInput;
    [SerializeField] TMP_Text speedText;
    public GameObject yearCanvas,createCanvas,makeCanvas;
    
   
    Car newCar;
    void Start()
    {
        newCar = new Car(0000, "thing");
        yearCanvas.SetActive(false);
        createCanvas.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
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
    public void OnClickGetMake()
    {
        if(carMakeInput.text == "")
        {
            return;
        }
        
        newCar.Make = carMakeInput.text;       
        makeCanvas.SetActive(false);
        yearCanvas.SetActive(true);
      
    }
    public void OnClickGetYear()
    {
     
        newCar.Year = int.Parse(carYearInput.text);   
        yearCanvas.SetActive(false);
        createCanvas.SetActive(true);    

    }
    

    public void OClickCreateCar()
    {
        carMakeTxt.text = newCar.Make;
        carYearTxt.text = newCar.Year.ToString();
    }
}
