using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] public int score = 0;
    [SerializeField] public int lives = 3;
    [SerializeField] TextMeshProUGUI livesText;

    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int SetLives(int newLives) 
    {
        lives = newLives; 
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives; 
        }
        return lives;
    }

    public void CheckLives()
    {
        if(lives <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
