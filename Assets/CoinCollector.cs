
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCounter counter = FindAnyObjectByType<CoinCounter>();

            if (counter != null)
            {
                counter.AddCoin();
            }

            Destroy(gameObject);
        }
    }
}
