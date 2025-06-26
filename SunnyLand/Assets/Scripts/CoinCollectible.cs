using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    
    public GameManager gameManager; 

    void Start()
    {
        
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
    }

   
    void OnTriggerEnter2D(Collider2D other)
    {
         if (other.CompareTag("Player")) 
        {
            if (gameManager != null)
            {
                gameManager.AddPoints(1); 
            }
            Destroy(gameObject); 
        }
    }
}