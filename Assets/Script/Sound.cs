
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource[] musicTracks;

    // Start is called before the first frame update
    void Start()
    { 
        int rand = Random.Range(0, musicTracks.Length);
        musicTracks[rand].Play();
    }


}
