using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulia : MonoBehaviour
{
    private bool move;

    void Start()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        move = true;
    }


    void Update()
    {
        if (transform.localPosition.y < -800) {
            transform.localPosition = new Vector3(0, 0, 0);

        }
        if (move == true)
        {
            move = false;
            StartCoroutine(Move());
        }
    }

    IEnumerator Move()
    {
        Debug.Log(Time.deltaTime * 0.0001f);
        yield return new WaitForSeconds(Time.deltaTime * 0.00001f);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 5);
        move = true;
    }

}