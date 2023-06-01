using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "速度:" + score_num;

        score_num += 1;
    }
}
