using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //play button
    public void GoToScreen()
    {
        SceneManager.LoadScene("Game");
    }
}
