using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    // Audio source for getting a point
    public AudioSource dingSFX;

    void Start()
    {
        dingSFX = GetComponent<AudioSource>();
    }

    // ContextMenu probably adds a menu to unity inspector to activate the function below
    // Can't use parameters with ContextMenu
    [ContextMenu("Increase Score")]
    public void addScore(int scoreAdded)
    {
        score += scoreAdded;
        scoreText.text = score.ToString();
        dingSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
