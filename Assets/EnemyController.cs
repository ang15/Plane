using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float health;
    public GameObject rocket;
    public GameObject rocketPrefab;
    public EnemyRoad enemys;

    void Start()
    {
        health = 1;
        GameObject rocketNew = Instantiate(rocketPrefab, transform);
        rocket = rocketNew;
    }


    void Update()
    {
 
        if (health == 0)
        {
            gameObject.SetActive(false);
            enemys.enemyAmount -= 1;
            rocket.transform.localPosition=new Vector2(0,0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "rockets")
        {
            health = health - 0.5f;
            Destroy( collision.gameObject);

        }
    }
}
