using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject CanvasInfoCore, CanvasResult;
    [SerializeField] private Text TextWeightDisplay, TextHeightDisplay;
    [SerializeField] private InputField InputWeight, InputHeight;
    [SerializeField] private Slider sliderWeight, sliderHeight;
    // Start is called before the first frame update
    void Start()
    {
        CanvasInfoCore.SetActive(true);
        CanvasResult.SetActive(false);        
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
        // TextWeightDisplay.text = InputWeight.text + " Kg";
    }
    public void DisplayHeightAtualization()
    {
        TextHeightDisplay.text = sliderHeight.value.ToString("F");
        // TextHeightDisplay.text = InputHeight.text + " m";
    }
}
