using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    static public string userName;

    public InputField nameIF;

    public void StartGame()
    {
        if (nameIF.text == null || nameIF.text.Length < 1)
        {
            Debug.Log("Name is empty");
        }
        else
        {
            userName = nameIF.text;
            SceneManager.LoadScene(1);
        }
    }

    public void QuitGame()
    {
        
    }
}
