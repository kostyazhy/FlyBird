using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Text scoreText;
    public static int score = 0; 
    void Start()
    {
        score = 0;
        scoreText = FindObjectOfType<Score>().GetComponent<Text>();
    }
}
