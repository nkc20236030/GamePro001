using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    private Text time_gauge; // �\������e�L�X�g
    private GameDirector gameDirector;

   private void Start()
    {
        time_gauge = GetComponent<Text>();
        gameDirector = FindObjectOfType<GameDirector>();
    }

    void Update()
    {
        
    }
}
