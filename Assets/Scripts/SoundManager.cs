using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    //Outlets
    AudioSource audioSource;
    public AudioClip getKeySound;
  
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySoundGetKey()
    {
        audioSource.PlayOneShot(getKeySound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
