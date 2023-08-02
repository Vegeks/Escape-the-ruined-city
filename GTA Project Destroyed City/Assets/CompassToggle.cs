using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInventory playerInventory;
    public void Start()
    {
        gameObject.SetActive(false);
        if (playerInventory.NumberOfDiamonds >= 3)
        {
            Debug.Log("Yes!");
            gameObject.SetActive(true);
        }
    }
    
}
