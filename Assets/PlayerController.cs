using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {

    }

    void Update()
    {
        

        float x = Input.GetAxisRaw("Horizontal");
        float speed = 0.05f;
        transform.position += new Vector3(x * speed, 0, 0);

        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);
    }
}
