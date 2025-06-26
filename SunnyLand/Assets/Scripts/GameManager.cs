using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour  
{
    
    public int score; // 
    public int lives; // 
    public TMP_Text scoreText; // 
    public TMP_Text livesText; // 

   
    void Start()
    {
        
        lives = 3; 
        score = 0; 
        UpdateHUD();     }

    
    
    public void AddPoints(int quantidade) // 
    {
        score += quantidade;
        UpdateHUD();
    }

    
    public void RemoveLife() // 
    {
        if (lives > 0) 
        {
            lives--;
            Debug.Log("Vida perdida! Vidas restantes: " + lives); // 
            if (lives <= 0)
            {
                Debug.Log("Game Over!"); // 
               
            }
        }
        UpdateHUD();
    }

    
    public void Heal() // 
    {
        if (lives < 5) 
        {
            lives++;
            Debug.Log("Vida adicionada! Vidas restantes: " + lives); // 
        }
        else
        {
            Debug.Log("Vida já está no máximo (5)!"); // 
            return; 
        }
        UpdateHUD();
    }

    
    public void UpdateHUD() // 
    {
        if (scoreText != null)
        {
            scoreText.text = "Moedas: " + score; // 
        }
        if (livesText != null)
        {
            livesText.text = "Vidas: " + lives; // 
        }
    }
}