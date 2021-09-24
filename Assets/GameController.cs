using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;
    public GameObject PF;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void Mudarcena(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    public void Sair()
    {
        Application.Quit();
    }
    public void ProxF()
    {
        PF.SetActive(true);
    } 
}
