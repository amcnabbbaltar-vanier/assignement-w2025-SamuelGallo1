using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSingleton : MonoBehaviour
{
    public static PauseSingleton Instance;
    // Start is called before the first frame update
    void Start()
    {
            DontDestroyOnLoad(gameObject); // Prevent the object from being destroyed when loading a new scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
