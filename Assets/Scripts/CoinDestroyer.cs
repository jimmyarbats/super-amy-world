using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyCoin();
        }
    }

    private void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
