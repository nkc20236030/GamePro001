using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //public Text speedText;

    Animator animator;
    //float speed;           
    //float axel;           
    //int bdash;

    void Start()
    {

    animator = GetComponent<Animator>();
        //speed = 0;
        //axel = 0.02f;
        //bdash = 1;
    }

    void Update()
    {
        float z = Input.GetAxisRaw("Vertical");

        if (z == 0)
        {
            animator.Play("Player");
        }
        else if (z == 1)
        {
            animator.Play("PlayerL");
        }
        else
        {
            animator.Play("PlayerR");
        }

        float x = Input.GetAxisRaw("Horizontal");
        float speed = 0.05f;
        transform.position += new Vector3(x * speed, 0, 0);

        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);

        //float sokudo = speed * bdash;
        //speedText.text = "‘¬“x " + sokudo.ToString("F2") + " m/s";

    }
}
