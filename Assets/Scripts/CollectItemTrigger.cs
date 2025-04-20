using UnityEngine;

public class CollectItemTrigger : MonoBehaviour
{
    public GameObject targetToReveal; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            if (targetToReveal != null)
            {
                targetToReveal.SetActive(true); 
            }

            Destroy(gameObject); 
        }
    }
}
