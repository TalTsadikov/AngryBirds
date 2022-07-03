using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI attemptsText;
    public Slingshot slingshot;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: ";
        attemptsText.text = "X5";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        attemptsText.text = "X" + slingshot.AttempsLeft.ToString();
    }

    public void BirdsLeftScore()
    {
        switch (slingshot.AttempsLeft)
        {
            case 1:
                score += 5000;
                break;
            case 2:
                score += 10000;
                break;
            case 3:
                score += 15000;
                break;
            case 4:
                score += 20000;
                break;
            case 5:
                score += 25000;
                break;
        }
    }
}
