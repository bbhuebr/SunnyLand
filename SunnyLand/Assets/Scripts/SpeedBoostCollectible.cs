using UnityEngine;
using System.Collections; 
public class SpeedBoostCollectible : MonoBehaviour
{
    public float speedIncreaseAmount = 5.0f; 
    public float duration = 10.0f; 
    public ParticleSystem speedBoostEffect; 

    private bool wasCollected = false; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !wasCollected)
        {
            Debug.Log("Jogador colidiu com Speed Boost!"); 

            wasCollected = true;

            wasCollected = true; 
         
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                
                playerMovement.runSpeed += speedIncreaseAmount;
                Debug.Log("Velocidade do jogador aumentada! Velocidade atual: " + playerMovement.runSpeed);

                
                StartCoroutine(ResetSpeedAfterDuration(playerMovement));
            }

            
            if (speedBoostEffect != null)
            {
                Instantiate(speedBoostEffect, transform.position, Quaternion.identity);
            }

           
            Destroy(gameObject);
        }
    }

   
    IEnumerator ResetSpeedAfterDuration(PlayerMovement player)
    {
        
        yield return new WaitForSeconds(duration);

        
        if (player != null)
        {
            player.runSpeed -= speedIncreaseAmount; 
            Debug.Log("Velocidade do jogador normalizada. Velocidade atual: " + player.runSpeed);
        }
    }

}
