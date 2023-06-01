using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Text distanceText; // ������\������Text�R���|�[�l���g

    private float distanceTraveled = 0f;

    Animator animator;

    void Start()
    {

    animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distancePerFrame = 60f * Time.deltaTime; // 1�t���[��������̐i�ދ���
        distanceTraveled += distancePerFrame; // �i�񂾋������X�V

        // �������e�L�X�g�ɕ\��
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
