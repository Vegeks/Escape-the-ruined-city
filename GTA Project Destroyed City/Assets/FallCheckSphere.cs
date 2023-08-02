using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallCheckSphere : MonoBehaviour
{

    // Update is called once per frame
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "FallCheck")
        {
            //Debug.Log("Collision Detected!");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene("EndScreen");
        }

    }
    
}
