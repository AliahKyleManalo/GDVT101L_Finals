using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfTomato { get; private set; }

    public UnityEvent<PlayerInventory> OnTomatoCollected;

    public void TomatoCollected()
    {
        NumberOfTomato++;
        OnTomatoCollected.Invoke(this);
    }
}
