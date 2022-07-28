using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float life;
    public GameObject pulia;
    public GameObject prefab;
    public EnemyRoad enemys;

    void Start()
    {
        life = 1;
        CreatePrefab();
    }


    void Update()
    {
        Finish();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pulias")
        {
            life =life- 0.5f;
            Destroy(collision.gameObject);
        }
    }

    private void Finish()
    {
        if (life == 0)
        {
            gameObject.SetActive(false);
            enemys.enemyAmount -= 1;
            pulia.transform.localPosition = new Vector2(0, 0);
            pulia.GetComponent<Pulia>().movement=true;
        }
    }
    private void CreatePrefab() { 
        GameObject puliaNew = Instantiate(prefab, transform);
        puliaNew.GetComponent<Pulia>().movement = true;
        pulia = puliaNew;
    }
}
