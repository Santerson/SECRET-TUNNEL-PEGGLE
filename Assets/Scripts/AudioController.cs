using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource mainmenumusic;
    [SerializeField] AudioSource gamemusic;

    public void playmenumusic()
    {
        gamemusic.Stop();
        mainmenumusic.Play();
    }

    public void playgamemusic()
    {
        mainmenumusic.Stop();
        gamemusic.Play();
    }
}
