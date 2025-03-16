using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public int scoreValue = 50; // Value for score power-up
    public float jumpBoostDuration = 30f; // Duration of jump boost
    public float speedBoostDuration = 5f;
    public enum Type  {JUMP, SCORE, SPEED};
    public Type type;
    public float rotationSpeed = 50f; // Speed of rotation
    public GameObject collectionEffect; // Optional particle effect prefab

    void start()
    {

    }
    void Update()
    {
        // Rotate the power-up around the Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (type)
            {
                case Type.SCORE:
                    HandleScorePowerUp();
                    break;
                case Type.JUMP:
                    HandleJumpPowerUp(other.GetComponent<CharacterMovement>());
                    break;
                case Type.SPEED:
                    HandleSpeedPowerUp(other.GetComponent<CharacterMovement>());
                    break;
            }
            Destroy(gameObject);
        }
    }
    
    private void HandleScorePowerUp()
    {
        GameManager.Instance.AddScore(scoreValue); // Add to score
        Debug.Log("Score power-up collected!");
    }

    private void HandleJumpPowerUp(CharacterMovement player)
    {
        if (player != null)
        {
            player.ActivateJumpBoost(jumpBoostDuration); // Activate jump boost
            Debug.Log("Jump boost power-up collected!");
        }
    }

    private void HandleSpeedPowerUp(CharacterMovement player)
    {
        if (player != null)
        {
            player.ActivateSpeedBoost(speedBoostDuration); // Activate speed boost
            Debug.Log("Speed boost power-up collected!");
        }
    }
}
