using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.pontuacao += 1; 
            Destroy(gameObject);
        }
    }
}
