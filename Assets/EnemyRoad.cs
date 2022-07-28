using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoad : MonoBehaviour
{
    public bool movement;
    public int enemyAmount;
    [SerializeField]
    private int enemyAmount2;
    public GameObject[] enemys;
    private bool movement2;
    private bool movement3;
    private bool movement4;

    private void Start()
    {
        movement = true;
        movement2 = true;
    }

    private void FixedUpdate()
    {
        IsPosition();

        if (transform.localPosition.y > -705)
        {
            if (movement2==true && movement == true)
            {
                    movement = false;
                    StartCoroutine(Move());
            }
        }
        else
        {
            OnMovement();
        }
    }

    private void  IsPosition()
    {
        if (transform.localPosition.y <= -235 && movement3 == false)
        {
            movement2 = false;
        }
        else
        if (transform.localPosition.y <= -950 && movement4 == false)
        {
            movement2 = false;
        }
        else
        {
            movement2 = true;
        }

        OnMove();
    }
    
    private void OnMovement()
    {
        transform.localPosition = new Vector3(0, 300, 0);
        for (int i = 0; i < 2; i++)
        {
            enemys[i].SetActive(true);
            enemys[i].GetComponent<EnemyController>().life = 1;
        }
        movement3 = false;
        movement4 = false;
        enemyAmount = enemyAmount2;
    }


    public void OnMove()
    {
        if (movement3 == false && enemyAmount == 3)
        {
            movement3 = true;
            for (int i = 2; i < enemys.Length - 1; i++)
            {
                enemys[i].SetActive(true);
                enemys[i].GetComponent<EnemyController>().life = 1;
            }
            enemys[enemys.Length - 1].SetActive(true);
        }
        else if (enemyAmount == 0 && movement4 == false)
        {
            movement4 = true;
        }
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.1f* Time.deltaTime*10);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 10);
        movement = true;
    }
}