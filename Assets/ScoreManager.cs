using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;
    public int remainingTime;
    // tao bien kieu textMeshProGui
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverPanelScoreText;
    
    void Awake ()
    {
        if (Instance == null) 
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
        else 
        {
            Destroy(this.gameObject);
        }


    }

    // Start is called before the first frame update
    public void AddScore(int amount)
    {
        score += amount;
    }
// them ham cong thoi gian
    public void AddTime(int time)
    {
        remainingTime += time;
    }
    // Update is called once per frame
    private void Start()
    {
        //remainingTime = 10; // thoi gian
        StartCoroutine(CountDowntimer());
    }
    void Update()
    {
        scoreText.text = $"Score: {score} | Time: {remainingTime}";
        
    }
    private IEnumerator CountDowntimer()
    {
        while (remainingTime >0)
        {
            yield return new WaitForSeconds(1f);
            remainingTime--;

            if (remainingTime <= 0)
            {
                GameOver();

            }
        }

    }
    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverPanelScoreText.text = $"Score: {score}";
        Time.timeScale = 0;
    }
    public void ReplayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
