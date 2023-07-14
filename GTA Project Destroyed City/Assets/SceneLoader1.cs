using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.anyKeyDown)
        {
             SceneManager.LoadScene("SampleScene");
        }
    }

    
}
