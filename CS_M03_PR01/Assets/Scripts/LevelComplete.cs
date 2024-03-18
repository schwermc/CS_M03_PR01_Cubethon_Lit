using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // Load next scene from animation event
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
