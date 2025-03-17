using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aptechka : MonoBehaviour
{
    public PlayerControl player;
    int count = 0;
    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth += 10f;
        count++;
        if (count == 7)
        {
            Destroy(gameObject);
        }

    }
}
