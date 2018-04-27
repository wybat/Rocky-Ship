using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

	public void playgame1()
    {
        SceneManager.LoadScene(1);
    }
    public void playgame2()
    {
        SceneManager.LoadScene(2);
    }
    public void playgame3()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
