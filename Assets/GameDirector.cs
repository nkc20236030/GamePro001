using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;
    public float totalTime = 100f;
    public Text timerText;
    public float limit = 1.0f / 6000.0f;
    float time = 1.0f;
    private float timeLeft;

    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
        timeLeft = totalTime;
    }

   public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 1.0f / 600.0f;
    }

    private void Update()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= limit;

        timeLeft -= Time.deltaTime; // 経過時間を減算

        if (timeLeft <= 0)
        {
            timeLeft = 0;
        }

        // 残り時間をテキストに表示
        timerText.text = "Time: " + Mathf.Round(timeLeft).ToString();
    }
}
