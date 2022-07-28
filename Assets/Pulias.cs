using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulias : MonoBehaviour
{
    [SerializeField]
    private bool movement;

    private void FixedUpdate()
    {
        
        OnMovement();

        if (IsPosition())
        {
            Destroy(gameObject);
        }
    }

    private bool IsPosition()
    {   
        return transform.localPosition.y > 900;
      
    }

    private void OnMovement()
    {
        if (movement == true)
        {
            movement = false;
            StartCoroutine(Movement());
        }

    }

    IEnumerator Movement()
    {   yield return new WaitForSeconds(Time.fixedDeltaTime* 0.00001f);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y+5); 
       
        movement = true;
    }

}