using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monets : MonoBehaviour
{
    [SerializeField]
    private Plane player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.health += 0.2f;
            gameObject.SetActive(false);
        }
    }
}
