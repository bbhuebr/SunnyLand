using UnityEngine;

public class HealCollectible : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem healParticle; 
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
                gameManager.Heal(); 
            }

            if (healParticle != null)
            {
                Instantiate(healParticle, transform.position, Quaternion.identity); 
            }
            Destroy(gameObject);
        }
    }
}