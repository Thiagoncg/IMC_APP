using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImcCalculator : MonoBehaviour
{
    [SerializeField]
    private float _weight = 75.5f;

    [SerializeField]
    private float _height = 1.70f;

    [SerializeField]
    private float _imcResult;

    //Script que efetua o calculo do imc de acordo com dos dados 
    //https://social.msdn.microsoft.com/Forums/pt-BR/a3b0807d-bf4e-402d-80f8-d25d80bdf9e6/calculo-imc-em-c-console-application?forum=vscsharppt
    // imc=(P /(A*A ));

    //Peso = 1.70m
    //Altura = 75.5

    // Seu IMC é 26.1
    // IMC entre 25.0 e 29.9
    // Sobrepeso

    private void Start()
    {
        CalculatorImc();
        IMCVerification();
    }

    public void CalculatorImc()
    {
        _imcResult = (_weight / (_height * _height));
        Debug.Log("IMC Result: " + _imcResult.ToString("F"));
    }

    private void IMCVerification()
    {
            if (_imcResult < 18.5)
            {
                Debug.Log("Peso abaixo do normal");
            }
            else if ((_imcResult > 18.5) && (_imcResult < 25))
            {
                Debug.Log("Peso normal");
            }
            else  if ((_imcResult > 25) && (_imcResult < 30))
            {
                Debug.Log("Sobre o Peso");
            }
            else if ((_imcResult > 30) && (_imcResult < 35))
            {
                Debug.Log("Grau de Obesidade I");
            }
            else if ((_imcResult > 35) && (_imcResult < 40))
            {
                Debug.Log("Grau de Obesidade II");
            }
            else  if (_imcResult > 40)
            {
                Debug.Log("Obesidade Grau III");
            }
    }
}
