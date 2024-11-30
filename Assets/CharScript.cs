using UnityEngine;
using UnityEngine.SceneManagement;

public class CharScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   public void CharBack()
   {
       SceneManager.LoadSceneAsync(0);
   }
   public void CharNext()
   {
       SceneManager.LoadSceneAsync(2);
   }
}
