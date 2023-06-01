using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Text distanceText; // 距離を表示するTextコンポーネント

    private float distanceTraveled = 0f;

    Animator animator;

    void Start()
    {

    animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distancePerFrame = 60f * Time.deltaTime; // 1フレームあたりの進む距離
        distanceTraveled += distancePerFrame; // 進んだ距離を更新

        // 距離をテキストに表示
        distanceText.text = "Distance: " + distanceTraveled.ToString("F2") + "km";
    

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

    }
}
