using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiatePowerUps : MonoBehaviour
{
    public GameObject[] powerUps;
    public Transform[] spawnLocations;
    public float checkInterval = 5f;

    private void Start()
    {
        InvokeRepeating("CheckPowerUp", 0f, checkInterval);
    }

    public void CheckPowerUp()
    {
        if(GameObject.FindWithTag("PowerUp") == null)
        {
            SpawnPowerups();
        }
    }

    public void SpawnPowerups()
    {
        int jumpPowerUpIndex = 0;
        int jumpLocationIndex = 0;
        int speedPowerUpIndex = 1;
        int speedLocationIndex = 1;
        Instantiate(powerUps[jumpPowerUpIndex], spawnLocations[jumpLocationIndex].position, Quaternion.identity);
        Instantiate(powerUps[speedPowerUpIndex], spawnLocations[speedLocationIndex].position, Quaternion.identity);
    }
}
