using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    int score;
    public Text scoreText;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene("BallBounceGame");
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
