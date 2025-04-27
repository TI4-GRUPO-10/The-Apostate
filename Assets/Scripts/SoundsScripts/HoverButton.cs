using UnityEngine;
using UnityEngine.EventSystems;
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)

public class HoverButton : MonoBehaviour, IPointerEnterHandler
{
    
    public AudioClip hoverSound;
    private AudioSource audioSource;
<<<<<<< HEAD

    public AudioMixerGroup mixerGroup;

=======
>>>>>>> c1b9b96 (Soud Track Music)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
<<<<<<< HEAD

        if(audioSource != null && mixerGroup != null){
            audioSource.outputAudioMixerGroup = mixerGroup;
        }
=======
>>>>>>> c1b9b96 (Soud Track Music)
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSound != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }

<<<<<<< HEAD
=======
    // Update is called once per frame
    void Update()
    {
        
    }
>>>>>>> c1b9b96 (Soud Track Music)
}
