using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
    
    public float health;
    [SerializeField]
    private Slider slider;
    public GameObject rocketPrefab;
    public Transform canvas;


    void Start()
    {
        health = 1f;
        slider.value = 1;
        GameObject rocketNew = Instantiate(rocketPrefab, canvas);
        rocketNew.transform.localPosition = transform.localPosition;
    }


    void Update()
    {
        slider.value = health;
        
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnMouseDown()
    {
        GameObject rocketNew = Instantiate(rocketPrefab, canvas);
        rocketNew.transform.localPosition = transform.localPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "rocket")
        {
           health-=0.1f;
           collision.gameObject.GetComponent<Pulia>().transform.localPosition = new Vector3(0, 0, 0);

        }
    }

}