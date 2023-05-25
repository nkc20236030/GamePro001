using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject MyChar_0;

    void Start()
    {
        this.MyChar_0 = GameObject.Find("MyChar_0");
    }

    void Update()
    {
        transform.Translate(-0.01f, 0, 0);
    }
}
