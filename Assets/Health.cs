using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public PlayerControl player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float healthPercent = (player.currHealth / player.maxHealth) * 100;
        float healthLevel = healthPercent / 10;

        transform.localScale = new Vector3(healthLevel, 0.5f, 0.5f);
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 7f, transform.position.z);
    }
}
