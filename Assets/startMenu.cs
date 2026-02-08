using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    
    public void startGame()
    {
        // Load the scene that is next in the queue
        // Queue is determined by the order in the build menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
