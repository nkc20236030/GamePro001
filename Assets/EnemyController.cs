using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.Translate(-0.01f, 0, 0);

        if(transform.position.x < -12)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Player. transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;   
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);
        }
    }
}
