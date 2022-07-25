using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulias : MonoBehaviour
{
    private bool move;

    public bool colision;

    void Start()
    {
        colision = false;
        move = true;
    }


    void Update()
    {
 
        if (move == true)
        {
            move = false;
            StartCoroutine(Move());
        }
        if (transform.localPosition.y>900)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Move()
    {
        Debug.Log(Time.deltaTime * 0.0001f);
        yield return new WaitForSeconds(Time.deltaTime * 0.00001f);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y+5);
        move = true;
    }

}