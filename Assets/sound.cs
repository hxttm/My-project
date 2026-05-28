using UnityEngine;

public class sound : MonoBehaviour
{
    public int collectibleScore = 0;
    AudioSource collectibleAudio;
    void Start()
    {
        collectibleAudio= GetComponent<AudioSource>();
    }

    public void Collect()
    {
        if(collectibleAudio != null)

        {
            collectibleAudio.Play();
        }
        Destroy(gameObject);
    }
}