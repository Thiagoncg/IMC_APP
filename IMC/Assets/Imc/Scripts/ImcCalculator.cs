using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;


public class ImcCalculator : MonoBehaviour
{
    //PRIVATE VARIABLES
    [SerializeField]    private float _weight, _height, _imcResult;

    //UI VARIABLES
    [SerializeField] private InputField inputWeight, inputHeight;
    [SerializeField] private Text textImcResultDisplay, textImcDescription;

    public void CalculatorImc()
    {
        _weight = float.Parse(inputWeight.text);
        _height = float.Parse(inputHeight.text);

        _imcResult = ( _weight / (_height * _height));
        Debug.Log("IMC Result: " + _imcResult.ToString("F"));

        IMCVerification(); 
    }

    private void IMCVerification()
    {
        if (_imcResult < 18.5)
        {
            textImcDescription.text = "Peso abaixo do normal";
            Debug.Log("Peso abaixo do normal");
        }
        else if ((_imcResult > 18.5) && (_imcResult < 25))
        {
            textImcDescription.text = "Peso normal";
            Debug.Log("Peso normal");
        }
        else if ((_imcResult > 25) && (_imcResult < 30))
        {
            textImcDescription.text = "Sobre o Peso";
            Debug.Log("Sobre o Peso");
        }
        else if ((_imcResult > 30) && (_imcResult < 35))
        {
            textImcDescription.text = "Grau de Obesidade I";
            Debug.Log("Grau de Obesidade I");
        }
        else if ((_imcResult > 35) && (_imcResult < 40))
        {
            textImcDescription.text = "Grau de Obesidade II";
            Debug.Log("Grau de Obesidade II");
        }
        else if (_imcResult > 40)
        {
            textImcDescription.text = "Obesidade Grau III";
            Debug.Log("Obesidade Grau III");
        }

        textImcResultDisplay.text = (_imcResult.ToString("F") + "Kg/m²");
    }
}
