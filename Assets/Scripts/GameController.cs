using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;

    public GameObject victoryPanel;
    public AudioClip victorySound;


    public static GameController instance;

    public AudioClip gameOverSound;
    public AudioSource sfxSource;

    public AudioSource musicSource;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (gameOver != null)
            gameOver.SetActive(false);

        if (victoryPanel != null)
            victoryPanel.SetActive(false);   

        if (scoreText != null)
            scoreText.text = totalScore.ToString();
    }

    public void UpdateSocreText()
    {
        if (scoreText != null)
        {
            scoreText.text = totalScore.ToString();
        }
        else
        {
            Debug.LogWarning("ScoreText NÃO foi atribuído no Inspector do GameController.");
        }
    }

    public void ShowGameOver()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }

        if (gameOver != null)
        {
            gameOver.SetActive(true);
        }
        else
        {
            Debug.LogError("gameOver NÃO foi atribuído no Inspector do GameController.");
        }

        if (sfxSource != null && gameOverSound != null)
        {
            sfxSource.PlayOneShot(gameOverSound);
        }
    }

    public void RestartCurrentLevel()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ShowVictory()
    {

        if (musicSource != null)
            musicSource.Stop();

        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }
        else
        {
            Debug.LogError("victoryPanel NÃO foi atribuído no Inspector do GameController.");
        }
        if (sfxSource != null && victorySound != null)
        {
            sfxSource.PlayOneShot(victorySound);
        }
    }
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainMenu");
    }
}
