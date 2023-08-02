using UnityEngine;

public class diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collision!");
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}