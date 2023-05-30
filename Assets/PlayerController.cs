using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float speed;           
    float axel;           
    int bdash;

    void Start()
    {
        speed = 0;
        axel = 0.02f;
        bdash = 1;
    }

    void Update()
    {
        

        float x = Input.GetAxisRaw("Horizontal");
        float speed = 0.05f;
        transform.position += new Vector3(x * speed, 0, 0);

        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);

        float sokudo = speed * bdash;
        // speedText.text = "‘¬“x " + sokudo.ToString("F2") + " m/s";

    }
}
