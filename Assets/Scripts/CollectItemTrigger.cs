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

            // Notify the WorldSwitcher
            WorldSwitcher ws = FindObjectOfType<WorldSwitcher>();
            if (ws != null)
            {
                ws.CollectMemoryItem();
            }

            Destroy(gameObject); 
        }
    }
}
