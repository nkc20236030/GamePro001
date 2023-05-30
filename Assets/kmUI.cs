using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class kmUI : MonoBehaviour
{
    GameObject MyChar_0;
    GameObject distance;

    void Start()
    {
        this.MyChar_0 = GameObject.Find("MyChar_0");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.MyChar_0.transform.position.x;

        this.distance.GetComponent<TextMeshProUGUI>().text =
                " :" + length.ToString("F1") + "km";
    }
}
