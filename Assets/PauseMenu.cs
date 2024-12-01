using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    private bool paused = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
        paused = true;
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
