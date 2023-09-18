using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool isGrounded = true;
    public bool isGameOver = false;

    public TextMeshProUGUI ScoreText;
    public GameObject gameOverScreen;
    public int scoreValue = 0;

    private void Awake()
    {
        gameOverScreen.SetActive(false);

    }
    public void UpdateScore(int objectValue)
    {
        scoreValue += objectValue;
    }
    public void GameOver()
    {
        StartCoroutine(GameOverCoroutine());
        Debug.Log("Game Over in GameController");
        GameManager.Instance.SaveHighScoreData(scoreValue);
        isGameOver = true;
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameRestart()
    {
        Time.timeScale= 1f;
        isGameOver= false;
        gameOverScreen.SetActive(false);
        GameManager.Instance.SaveHighScoreData(scoreValue);
       // SceneManager.LoadScene("Main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("game restart");
    }

    public void OnHomeBtnClick()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("Startmenu");
        Debug.Log("HomeBtnClick");
    }
    private void Update()
    {
        ScoreText.text = "Score: " + scoreValue;
    }

    private IEnumerator GameOverCoroutine()
    {
         yield return new WaitForSeconds(3);
       
    }
}
