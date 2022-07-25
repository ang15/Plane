using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoad : MonoBehaviour
{
    public bool move;
    public int enemyAmount;
    [SerializeField]
    private int enemyAmount2;
    public GameObject[] enemys;
    private bool move2;
    private bool move4;
    private bool move5;

    void Start()
    {
        move = true;
        move2 = true;
    }

    void Update()
    {
        if (transform.localPosition.y <= -235 && move4 == false)
        {
                move2 = false;
            
        }else        
        if (transform.localPosition.y <= -950 && move5 == false)
        {
           move2 = false;
            
        }else
        {
            move2 = true;
        }
        OnMove();
        if (transform.localPosition.y > -2031)
        {
            if ( move2==true)
            {
                if (move == true)
                {
                    move = false;
                    StartCoroutine(Move());
                }
            }
        }
        else
        {
            transform.localPosition = new Vector3(0, 300, 0);
            for (int i = 0; i < 2; i++)
            {
                enemys[i].SetActive(true);
                enemys[i].GetComponent<EnemyController>().health = 1;
            }
            enemys[2].SetActive(true);
            move4 = false;
            move5 = false;
            enemyAmount = enemyAmount2;
        }

        
    }

    public void OnMove()
    {
        if (move4 == false && enemyAmount == 3)
            {
                move4 = true;
                for (int i = 3; i < enemys.Length - 1; i++)
                {
                    enemys[i].SetActive(true);
                    enemys[i].GetComponent<EnemyController>().health = 1;
                }
                enemys[enemys.Length - 1].SetActive(true);

            }
            else if (enemyAmount == 0 && move5==false)
            {
                move5 = true;
              
            }
        
    }
    IEnumerator Move()
    {
        Debug.Log(1.1f * Time.deltaTime * 100);
        yield return new WaitForSeconds(1.1f* Time.deltaTime*10);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 10);
        move = true;
    }
}
