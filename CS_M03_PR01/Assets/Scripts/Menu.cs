using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Idea: change button color from #C0C0C0 to #323232 depending if SleaseMode is active or not
 */

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SleaseModeActive()
    {
        SleaseMode.sleaseMode();
    }
}