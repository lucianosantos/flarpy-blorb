using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public long score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public SoundManager soundManager;

    private bool isGameOver = false;

    public void Start()
    {
        soundManager.Play("Soundtrack");
    }

    void Update()
    { }

    // Start is called before the first frame update
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (isGameOver)
        {
            return;
        }

        score += scoreToAdd;
        scoreText.text = score.ToString();
        soundManager.Play("ScoreUp");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameOver = false;
    }

    public void gameOver()
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        gameOverScreen.SetActive(true);

        soundManager.StopAll();
        soundManager.Play("GameOver");
    }
}
