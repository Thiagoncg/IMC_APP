using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;


public class ImcCalculator : MonoBehaviour
{
    //PRIVATE VARIABLES
    [SerializeField] private float _weight, _height, _imcResult;

    //UI VARIABLES
    [SerializeField] private InputField inputWeight, inputHeight;
    [SerializeField] private Text textImcResultDisplay, textImcDescription;
    [SerializeField] private Slider sliderWeight, sliderHeight;
    [SerializeField] private Image character;
    [SerializeField] private Sprite[] characterResult;
    [SerializeField] private Image imageSlider;


    void Start() 
    {
        character.GetComponent<Image>().sprite = characterResult[0];
    }
    public void CalculatorImc()
    {
        // _weight = float.Parse(inputWeight.text);
        // _height = float.Parse(inputHeight.text);

        _weight = sliderWeight.value;
        _height = sliderHeight.value;

        _imcResult = (_weight / (_height * _height) );
        Debug.Log("IMC Result: " + _imcResult.ToString("F"));

        IMCVerification(); 
    }

    private void IMCVerification()
    {
        if (_imcResult < 18.5)
        {

            textImcDescription.text = "Peso abaixo do normal \n Você está abaixo do peso ideal \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Peso abaixo do normal");

            character.GetComponent<Image>().sprite = characterResult[0];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 18.5) && (_imcResult < 25))        
        {

            textImcDescription.text = "Peso normal \n Parabéns, você esta no seu peso ideal, procure se manter assim";
            Debug.Log("Peso normal");

            character.GetComponent<Image>().sprite = characterResult[1];
            imageSlider.fillAmount = _imcResult / 100;
        }
        else if ((_imcResult > 25) && (_imcResult < 30))
        {
            
            textImcDescription.text = "Sobre o Peso \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Sobre o Peso");

            character.GetComponent<Image>().sprite = characterResult[2];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 30) && (_imcResult < 35))
        {

            textImcDescription.text = "Grau de Obesidade I \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Grau de Obesidade I");

            character.GetComponent<Image>().sprite = characterResult[3];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 35) && (_imcResult < 40))
        {

            textImcDescription.text = "Grau de Obesidade II \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Grau de Obesidade II");

            character.GetComponent<Image>().sprite = characterResult[4];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if (_imcResult > 40)
        {

            textImcDescription.text = "Obesidade Grau III \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Obesidade Grau III");

            character.GetComponent<Image>().sprite = characterResult[5];
            imageSlider.fillAmount = _imcResult / 100;

        }

        textImcResultDisplay.text = (_imcResult.ToString("F") + "Kg/m²");
    }
}
