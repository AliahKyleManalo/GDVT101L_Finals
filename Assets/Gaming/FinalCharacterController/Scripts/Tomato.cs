using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public float rotateSpeed = 100f;
    public float floatSpeed = 2f;
    public float floatHeight = 3.25f;

    public AudioClip collectSound;   
    public float volume = 1f;        

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);

        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            //Play effect at tomato position
            AudioSource.PlayClipAtPoint(collectSound, transform.position, volume);

            playerInventory.TomatoCollected();
            gameObject.SetActive(false);
        }
    }
}