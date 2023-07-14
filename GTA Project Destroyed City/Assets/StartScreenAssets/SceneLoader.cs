using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void QuitGame() {
            Application.Quit();
            Debug.Log("Quit!!");
        }

        
       
}
