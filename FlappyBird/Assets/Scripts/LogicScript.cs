using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public BirdScript player;
    public Text scoreText;
    public GameObject startButton;
    public GameObject playButton;
    public GameObject gameOver;
    // Start is called before the first frame 
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Start()
    {
        startButton.SetActive(true);
        gameOver.SetActive(false);
    }
    public void PLay()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        startButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        PipeMoveScript[] pipes = FindObjectsOfType<PipeMoveScript>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }
    public void GameOver()
    {

        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
       
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
}
