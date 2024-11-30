using UnityEngine;
using UnityEngine.SceneManagement;

public class MapScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   // public void goBack()
   // {   
   //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   // }
   public void MapNext()
   {
       SceneManager.LoadSceneAsync(4);
   }
   public void MapBack()
   {
       SceneManager.LoadSceneAsync(1);
   }
}