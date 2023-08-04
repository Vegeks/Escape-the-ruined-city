using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInventory playerInventory;
    //Image image;
    bool value = false;
    public void Start()
    {
        if (playerInventory.NumberOfDiamonds >= 20)
        {
            Debug.Log("Yosh!");
            value = true;
        }

        Debug.Log(value);
            gameObject.SetActive(value);

        //if (playerInventory.NumberOfDiamonds >= 3)
          //  {
           // value = true;
            //}
            //image = GetComponent<Image>();
            //GameController.Instance.Data.DialogOpen.Subscribe((value) =>
            //{
              //  image.enabled = value;
            //}).AddTo(this);
        
        //gameObject.SetActive(false);
       // if (playerInventory.NumberOfDiamonds >= 3)
        //{
          //  Debug.Log("Yes!");
            //gameObject.SetActive(true);
        //}
    }
    
    
}
