
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioSource collectSound;
    

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        
        //Play audio on chop
        collectSound.Play();

        if (playerInventory != null)
        {
           
            playerInventory.WoodCollected();
            gameObject.SetActive(false);
        }
    }
}
