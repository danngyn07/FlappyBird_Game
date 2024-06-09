using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public BirdScript player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    // Start is called before the first frame update
    private int scrore;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    private void PLay()
    {

    }
    public void GameOver()
    {
       

    }
    public void Pause()
    {

    }
    public void IncreaseScore()
    {
        scrore++;
        scoreText.text = scoreText.ToString();
    }
    
}
