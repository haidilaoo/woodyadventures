using UnityEngine;
using UnityEngine.Events;

// Keeps track of how much wood collected 

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfWood { get; private set; } //any script can read the value but only this script can set value

    public UnityEvent<PlayerInventory> OnWoodCollected;

    public void WoodCollected() //count how much collected
    {
        NumberOfWood++;
        OnWoodCollected.Invoke(this);
    }

}
