using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal2 : MonoBehaviour
{
    public PlayerControl player;
    void OnTriggerEnter2D(Collider2D obj)
    {

        SceneManager.LoadScene("Game3");


    }
}
