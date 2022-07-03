using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;

    public GameObject LevelWonPanel;
    public GameObject GameWonPanel;
    public GameObject GameOverPanel;

    public GameObject firstStar;
    public GameObject secondStar;
    public GameObject thirdStar;
    public GameObject lastLVLfirstStar;
    public GameObject lastLVLsecondStar;
    public GameObject lastLVLthirdStar;
   
    private int sceneIndex;

    private void Start()
    {
       scoreManager = gameObject.GetComponent<ScoreManager>();
       sceneIndex = SceneManager.GetActiveScene().buildIndex;
       LevelWonPanel.SetActive(false);
       GameWonPanel.SetActive(false);
    }

    public void GameWon()
    {
        if (Enemy.EnemiesAlive <= 0)
        {
            scoreManager.BirdsLeftScore();
            
            if (sceneIndex == 1)
            {
                FirstLevelScore();
                LevelWonPanel.SetActive(true);
            }
            else if (sceneIndex == 2)
            {
                SecondLevelScore();
                LevelWonPanel.SetActive(true);
            }
            else if (sceneIndex == 3)
            {
                ThirdLevelScore();
                GameWonPanel.SetActive(true);
            }
        }
    }

    public IEnumerator GameLost()
    {
        yield return new WaitForSeconds(3f);
        GameOverPanel.SetActive(true);
    }

    public void RestartButton()
    {
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevelButton()
    {
        Enemy.EnemiesAlive = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void FirstLevelScore()
    {
        if (ScoreManager.score >= 20000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(false);
            thirdStar.SetActive(false);
        }
        else
        {
            firstStar.SetActive(false);
            secondStar.SetActive(false);
            thirdStar.SetActive(false);
        }
        if (ScoreManager.score >= 23000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
            thirdStar.SetActive(false);
        }

        if (ScoreManager.score >= 26000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
            thirdStar.SetActive(true);
        }
    }

    void SecondLevelScore()
    {
        if (ScoreManager.score >= 20000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(false);
            thirdStar.SetActive(false);
        }
        else
        {
            firstStar.SetActive(false);
            secondStar.SetActive(false);
            thirdStar.SetActive(false);
        }

        if (ScoreManager.score >= 27000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
            thirdStar.SetActive(false);
        }

        if (ScoreManager.score >= 30000)
        {
            firstStar.SetActive(true);
            secondStar.SetActive(true);
            thirdStar.SetActive(true);
        }
    }

    void ThirdLevelScore()
    {
        if (ScoreManager.score >= 30000)
        {
            lastLVLfirstStar.SetActive(true);
            lastLVLsecondStar.SetActive(false);
            lastLVLthirdStar.SetActive(false);
        }
        else
        {
            lastLVLfirstStar.SetActive(false);
            lastLVLsecondStar.SetActive(false);
            lastLVLthirdStar.SetActive(false);
        }

        if (ScoreManager.score >= 35000)
        {
            lastLVLfirstStar.SetActive(true);
            lastLVLsecondStar.SetActive(true);
            lastLVLthirdStar.SetActive(false);
        }

        if (ScoreManager.score >= 40000)
        {
            lastLVLfirstStar.SetActive(true);
            lastLVLsecondStar.SetActive(true);
            lastLVLthirdStar.SetActive(true);
        }
    }
}
