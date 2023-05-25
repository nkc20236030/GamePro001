using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0_Prefab;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0_Prefab);
            int px = Random.Range(-5, -5);
            go.transform.position = new Vector2(10, px);
        }
    }   
}
