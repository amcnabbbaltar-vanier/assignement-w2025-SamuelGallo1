using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISingleton : MonoBehaviour
{
    public static UISingleton Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // Assign the instance
            DontDestroyOnLoad(gameObject); // Prevent the object from being destroyed when loading a new scene
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
