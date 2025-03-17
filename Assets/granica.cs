using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granica : MonoBehaviour
{
    public PlayerControl player;
    int count = 0;
    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth -= 100f;
        count++;
        if (count == 999999)
        {
            Destroy(gameObject);
        }

    }
}
