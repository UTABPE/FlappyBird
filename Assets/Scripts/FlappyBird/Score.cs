﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
    public int score;                                  
    public Text scoreText;

    void Start(){
        score = 0;
    }

    void Update(){
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Score")
        {
            score++;
        }
    }
}
