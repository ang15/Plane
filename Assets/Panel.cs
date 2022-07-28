using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField]
    private Transform plane;
    [SerializeField]
    private int amount;
    private int plus=-1;
    public void Move()
    {
        if (plane.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            plus = -1;
        }
        else
        {
            plus = 1;
        } 
        StartCoroutine(OnMove());
    }

    IEnumerator OnMove()
    {   Vector3 pozition = plane.localPosition;
         for (int i = 0; i < amount; i++)
        {
            yield return new WaitForSeconds(0.2f * Time.deltaTime);
             pozition.x +=plus* 10;
            plane.localPosition = pozition;
        }
    }


}

