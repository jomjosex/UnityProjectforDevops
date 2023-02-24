using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public int PlayerScore;
    public TMP_Text ScoreText;
    [SerializeField] private GameObject _gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        _gameOverScreen.SetActive(true);
    }
}
