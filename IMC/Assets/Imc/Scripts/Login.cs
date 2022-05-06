using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    [SerializeField] private InputField InputName;
    [SerializeField] private Button ButtonGirl, ButtonBoy;

    private void Awake() 
    {
        if (PlayerPrefs.GetString("Name") != "")
        {
            SceneManager.LoadScene("ImcCore");
        }        
    }

    private void Start() 
    {
        //Identifier click Gir button
        ButtonGirl = ButtonGirl.GetComponent<Button>();
        ButtonGirl.onClick.AddListener(BtnGirlClicked);

        //Identifier click boy button
        ButtonBoy = ButtonBoy.GetComponent<Button>();
        ButtonBoy.onClick.AddListener(BtnBoyClicked);
    }


    private void BtnGirlClicked()
    {
        PlayerPrefs.SetString("Gender","Girl");
        ButtonGirl.GetComponent<Image>().color = new Color(255,255,255,255);
        ButtonBoy.GetComponent<Image>().color = new Color(0,0,0,255);
    }

    private void BtnBoyClicked()
    {
        PlayerPrefs.SetString("Gender", "Boy");
        ButtonBoy.GetComponent<Image>().color = new Color(255,255,255,255);
        ButtonGirl.GetComponent<Image>().color = new Color(0,0,0,255);
    }

    public void HandlerLogin()
    {
        PlayerPrefs.SetString("Name", InputName.text);

        SceneManager.LoadScene("ImcCore");
    }
}
