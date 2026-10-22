using UnityEngine;

public class script : MonoBehaviour
{
   
    string playerName = "Ratchet";

    int playerHealth = 100;
    int playerLevel = 1;

    float playerExperience = 0;
    int playerScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // player takes damage from the enemy and loses half of their health
        playerHealth /= 2;

        // player drinks two potions to recover some (20) lost health
        playerHealth += 10;
        playerHealth += 10;

        // Player attacks the enemy back and defeats them, granting some experience points.
        playerExperience *= 1.25f;

        // Player successfully leveled up once
        playerLevel++;

        // The player acquires a new title
        playerName += " the Brave!";

    }

    // Update is called once per frame
    void Update()
    {
        playerScore = playerScore + 1;
        if ( /* condition a */ playerScore >= 100)
        {
            // Player has reached a score of 100 and is awarded a bonus
            playerScore += 50;
        }
        else if ( /* condition b */ playerScore >= 200)
        {
            // Player has reached a score of 200 and is awarded a bonus
            playerScore += 100;
        }
        else if ( /* condition c */ playerScore >= 300)
        {
            // Player has reached a score of 300 and is awarded a bonus
            playerScore += 150;
        }
        else if ( /* condition d */ playerScore >= 400)
        {
            // Player has reached a score of 400 and is awarded a bonus
            playerScore += 200;
        }
        else /* if no condition a, b, c, or d is met */
        {
            // Player has not reached any of the score milestones and is not awarded a bonus
            playerScore += 0;
        }

    }
}
