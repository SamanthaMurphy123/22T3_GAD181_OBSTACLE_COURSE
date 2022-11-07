using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void firstLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void secondLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}
