using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuScript : MonoBehaviour
{
    public void startGame(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    public void exit()
    {
        Application.Quit();
    }
}
