using UnityEngine;
using UnityEngine.SceneManagement;
public class MapButtons : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(3);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(1);
    }
}
