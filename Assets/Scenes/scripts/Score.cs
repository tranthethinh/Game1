using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    
    public int score = 0;
    public TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    public void AddScore(int myscore){
        score=score+myscore;
    }
    public void Update()
    {
        text.text = "Score: " + score.ToString();
    }
}
