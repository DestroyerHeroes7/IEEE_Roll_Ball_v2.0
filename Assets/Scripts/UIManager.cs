using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Player player;
    public Text winText;
    public Text timerText;
    public Text scoreText;
    public Button restartButton;
    private void Update()
    {
        timerText.text = player.timer.ToString("0");
    }
    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }
    public void OnGameEnd()
    {
        winText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        scoreText.color = Color.green;
    }
    public void OnScore(int score)
    {
        scoreText.text = score.ToString() + "/" + Global.coinCountForWin.ToString();
    }
}
