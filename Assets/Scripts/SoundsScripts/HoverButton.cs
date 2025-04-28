using UnityEngine;
using UnityEngine.EventSystems;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
using UnityEngine.Audio;
>>>>>>> cdbb466 (LoadScreen)

public class HoverButton : MonoBehaviour, IPointerEnterHandler
{
    
    public AudioClip hoverSound;
    private AudioSource audioSource;
<<<<<<< HEAD
<<<<<<< HEAD

    public AudioMixerGroup mixerGroup;

=======
>>>>>>> c1b9b96 (Soud Track Music)
=======

    public AudioMixerGroup mixerGroup;

>>>>>>> cdbb466 (LoadScreen)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> cdbb466 (LoadScreen)

        if(audioSource != null && mixerGroup != null){
            audioSource.outputAudioMixerGroup = mixerGroup;
        }
<<<<<<< HEAD
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
>>>>>>> cdbb466 (LoadScreen)
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSound != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
    // Update is called once per frame
    void Update()
    {
        
    }
>>>>>>> c1b9b96 (Soud Track Music)
=======
>>>>>>> cdbb466 (LoadScreen)
}
