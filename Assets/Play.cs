using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartPlaying()
    {
        SceneManager.LoadSceneAsync(4);
    }

  // public void goBack()
  // {   
  //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  // }
}
