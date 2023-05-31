using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class kmUI : MonoBehaviour
{
    GameObject Player;
    GameObject distance;

    void Start()
    {
        this.Player = GameObject.Find("Player");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.Player.transform.position.x;

        this.distance.GetComponent<TextMeshProUGUI>().text =
                " :" + length.ToString("F1") + "km";
    }
}
