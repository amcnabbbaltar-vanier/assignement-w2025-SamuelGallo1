using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePowerUps : MonoBehaviour
{
    public GameObject[] powerUps;
    public Transform[] spawnLocations;
    public float checkInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckPowerUp", 0f, checkInterval);
    }
    public void CheckPowerUp()
    {
        if(GameObject.Find("PowerUpJump") == null)
        {
            SpawnPowerups();
        }
    }

    public void SpawnPowerups()
    {
        int jumpPowerUpIndex = 0;
        int jumpLocationIndex = 0;
        Instantiate(powerUps[jumpPowerUpIndex], spawnLocations[jumpLocationIndex].position, Quaternion.identity);
    }
}
