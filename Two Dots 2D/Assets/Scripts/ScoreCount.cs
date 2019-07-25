using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    int score = 0;
    public Text ScoreText;
    // Start is called before the first frame update

    public void IncreaseScore()
    {
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }
}
