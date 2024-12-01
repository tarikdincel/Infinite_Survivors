using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterButtons : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(0);
    }
}