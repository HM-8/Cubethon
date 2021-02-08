using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    public AudioSource playerAudio;

    public void DisableAudio()
    {
        playerAudio.enabled = false;
    }
}
