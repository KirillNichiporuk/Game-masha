using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


   

public class Moneta : MonoBehaviour
{
    public TMP_Text textsny;
    public PlayerControl player;
    int count = 0;
    void onTriggerEnter2D(Collider2D obj)
    {
        Destroy(gameObject);
        textsny.text = player.Varenye.ToString();
        player.Varenye += 1f;
        count++;
        if (count == 1)
        {
            Destroy(gameObject);
        }
    }
}

