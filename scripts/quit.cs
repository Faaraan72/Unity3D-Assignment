using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
// Quits the player when the user hits escape

public class quit : MonoBehaviour
{
    public void quittest()
    {
        
                Application.Quit();
           
    }
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void playing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}