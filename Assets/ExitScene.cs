using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    public GameObject player;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x-25f, player.transform.position.y+11.5f);
    }
}
