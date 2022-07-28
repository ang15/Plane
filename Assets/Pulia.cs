using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulia : MonoBehaviour
{
    public bool movement;

    void FixedUpdate()
    {
        Finish();
        OnMovement();
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
    {   
        yield return new WaitForSeconds(Time.fixedDeltaTime * 0.00001f);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + 10);
        
        movement = true;
    }
   private void Finish()
    {
       if (transform.localPosition.y > 1610)
        {
            transform.localPosition = new Vector3(0, 0, 0);
            movement = true;
        }
    }
}