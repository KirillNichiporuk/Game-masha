using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OpenScene()
    {
        SceneManager.LoadScene("Scene");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenObIgre()
    {
        SceneManager.LoadScene("ObIgre");
    }

    public void Openstetings()
    {
        SceneManager.LoadScene("stetings");
    }

    public void OpenExit()
    {
        SceneManager.LoadScene("Exit");
    }

    public void Openlox()
    {
        SceneManager.LoadScene("lox");
    }

    public void OpenGame3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void Openskrim()
    {
        SceneManager.LoadScene("skrim");
    }

    public void OpenGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
