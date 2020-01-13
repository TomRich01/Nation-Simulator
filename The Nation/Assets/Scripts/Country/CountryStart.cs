using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountryStart : MonoBehaviour
{
   static public string countryName = "Utopia";
    public InputField inputField;
   public Text textOfMine;

    private void Start()
    {
       DisplayName();
    }
    public void setName(string name)
    {
        countryName = name;
    }

   public void DisplayName()
    {
        textOfMine.text = countryName;
        if (textOfMine == null)
        {
            Debug.Log("No text");
        }
    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }



}
