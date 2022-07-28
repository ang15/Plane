using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
    
    public float life;
    [SerializeField]
    private Slider sliderLife;
    public GameObject prefab;
    public Transform canvas;


    void Start()
    {
        life = 1f;
        sliderLife.value = 1;
        CreatePulia();
    }

    private void OnMouseDown()
    {
        CreatePulia();
    }


    void Update()
    {
        sliderLife.value = life;

        Finish();
    }
    private void Finish() {

        if (life <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Pulia")
        {
           life-=0.1f;
           IsPozition(collision.gameObject);

        }
    }

    private void IsPozition(GameObject pulia)
    {
        pulia.GetComponent<Pulia>().transform.localPosition = new Vector3(0, 0, 0);

    }

    private void CreatePulia()
    {
        GameObject rocketNew = Instantiate(prefab, canvas);
        rocketNew.transform.localPosition = transform.localPosition;
    }
}