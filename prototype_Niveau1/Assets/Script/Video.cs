using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "perso")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }
}
