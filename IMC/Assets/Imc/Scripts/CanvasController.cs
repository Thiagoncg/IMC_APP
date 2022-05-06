using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject CanvasInfoCore, CanvasResult;
    [SerializeField] private Text TextWeightDisplay, TextHeightDisplay;
    [SerializeField] private Slider sliderWeight, sliderHeight;
    // Start is called before the first frame update
    void Start()
    {
        CanvasInfoCore.SetActive(true);
        CanvasResult.SetActive(false); 

        Debug.Log("Seu nome : " + PlayerPrefs.GetString("Name"));   

        Debug.Log("Seu Sexo : " + PlayerPrefs.GetString("Gender"));    
    }

    public void BtnNextResult()
    {
        CanvasInfoCore.SetActive(false);
        CanvasResult.SetActive(true);
    }

    public void BtnReturn()
    {
        CanvasInfoCore.SetActive(true);
        CanvasResult.SetActive(false); 
    }

    public void DisplayWeightAtualization()
    {
        TextWeightDisplay.text = sliderWeight.value.ToString();
    }
    public void DisplayHeightAtualization()
    {
        TextHeightDisplay.text = sliderHeight.value.ToString("F");
    }
    public void ResetSettings()
    {
        PlayerPrefs.SetString("Gender", "");
        PlayerPrefs.SetString("Name", "");
        SceneManager.LoadScene("Login");
    }
}
