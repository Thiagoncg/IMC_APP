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
    [SerializeField] private Text textImcResultDisplay, textImcDescription, textName;
    [SerializeField] private Slider sliderWeight, sliderHeight;
    [SerializeField] private Image character;
    [SerializeField] private Sprite[] characterResultF;
    [SerializeField] private Sprite[] characterResultM;
    [SerializeField] private Sprite[] characterNull;
    [SerializeField] private Image imageSlider;

    //PRIVATE VARIABLES
    private string _name,  _gender;


    void Start() 
    {
        character.GetComponent<Image>().sprite = characterResultF[0];
        _gender = PlayerPrefs.GetString("Gender");
        _name = PlayerPrefs.GetString("Name");

        textName.text = _name;

        //Logica Caso o sexo escolhido for masculino vetor carrega com imagens masculinas se não carregara com imagens femininas (O padrão é feminino)
        if (_gender == "Boy")
        {
            characterNull = characterResultM;            
        }
        else if(_gender == "Girl")
        {
            characterNull = characterResultF;
        }
        else
        {
            characterNull = characterResultF;
        }

    }
    public void CalculatorImc()
    {
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

            character.GetComponent<Image>().sprite = characterNull[0];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 18.5) && (_imcResult < 25))        
        {

            textImcDescription.text = "Peso normal \n Parabéns, você esta no seu peso ideal, procure se manter assim";
            Debug.Log("Peso normal");

            character.GetComponent<Image>().sprite = characterNull[1];
            imageSlider.fillAmount = _imcResult / 100;
        }
        else if ((_imcResult > 25) && (_imcResult < 30))
        {
            
            textImcDescription.text = "Sobre Peso \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Sobre o Peso");

            character.GetComponent<Image>().sprite = characterNull[2];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 30) && (_imcResult < 35))
        {

            textImcDescription.text = "Grau de Obesidade I \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Grau de Obesidade I");

            character.GetComponent<Image>().sprite = characterNull[3];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if ((_imcResult > 35) && (_imcResult < 40))
        {

            textImcDescription.text = "Grau de Obesidade II \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Grau de Obesidade II");

            character.GetComponent<Image>().sprite = characterNull[4];
            imageSlider.fillAmount = _imcResult / 100;

        }
        else if (_imcResult > 40)
        {

            textImcDescription.text = "Obesidade Grau III \n Você está acima do peso! \n Procure se alimentar melhor e praticar exercícios físicos";
            Debug.Log("Obesidade Grau III");

            character.GetComponent<Image>().sprite = characterNull[5];
            imageSlider.fillAmount = _imcResult / 100;

        }

        textImcResultDisplay.text = (_imcResult.ToString("F") + "Kg/m²");
    }
}
