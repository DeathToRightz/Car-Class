using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Car;
using UnityEngine.SceneManagement;
public class TestCar : MonoBehaviour
{
    [SerializeField] TMP_InputField carYearInput;
    [SerializeField] TMP_Text carYearTxt;
    [SerializeField] TMP_Text carMakeTxt;
    [SerializeField] TMP_InputField carMakeInput;
    Car.TypeofCar testCar = new TypeofCar(0000, "Invalid Make");
    void Start()
    {
        
       

       
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickGetYear()
    {
        testCar.Year = int.Parse(carYearInput.text);
        carYearTxt.text = testCar.Year.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void ONClickGetMake()
    {
        testCar.Make = carMakeInput.text;
        carMakeTxt.text = testCar.Make.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
