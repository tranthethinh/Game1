using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearandappear : MonoBehaviour
{
    public Vector3 newPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("Reappear", 1f);
        }
    }

    private void Reappear()
    {
        newPosition=new Vector3(Random.Range(-8.0f, 8.0f), transform.position.y, Random.Range(-8.0f, 8.0f));
        gameObject.SetActive(true);
        transform.position = newPosition;
    }
}