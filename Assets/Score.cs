using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    private int scorePrint;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
         scoreText.text = "Enemies Killed: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Enemies Killed: " + scorePrint;
    }
    public void addScore()
    {
        scorePrint++;
    }
}
