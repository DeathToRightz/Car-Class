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
    string carMake;
    string carYear;
   
    Car newCar;
    void Start()
    {
        yearCanvas.SetActive(false);
        createCanvas.SetActive(false);
         

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up");
            
            
           
            speedText.text = newCar.IncreaseSpeed().ToString();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down");
           
           speedText.text = newCar.DecreaseSpeed().ToString();
        }
    }
    public void OnClickGetMake()
    {
        carMake = carMakeInput.text;
      
        makeCanvas.SetActive(false);
        yearCanvas.SetActive(true);
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnClickGetYear()
    {
        carYear = carYearInput.text;
        
        yearCanvas.SetActive(false);
        createCanvas.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    

    public void OClickCreateCar()
    {
        carMakeTxt.text = carMake;
        carYearTxt.text = carYear;
        
        newCar = new Car (int.Parse (carYear), carMake.ToString());
       
       
        
    }
}
