using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    [SerializeField]
    private int kol;
    public void Move()
    {
        StartCoroutine(OnMove());
    }

    IEnumerator OnMove()
    {
        Vector3 pozition = Player.localPosition;

            if (Player.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
            {
                if (pozition.x != -200)
                {
                    for (int i = 0; i < kol; i++)
                    {
                        yield return new WaitForSeconds(0.2f * Time.deltaTime);
                        pozition.x -= 10;
                        Player.localPosition = pozition;
                    }
                }
            }
            else
            {
                if (pozition.x != 200)
                {
                    for (int i = 0; i < kol; i++)
                    {
                        yield return new WaitForSeconds(0.2f * Time.deltaTime);
                        pozition.x += 10;
                        Player.localPosition = pozition;
                    }

                }
            }
        
    }
}

