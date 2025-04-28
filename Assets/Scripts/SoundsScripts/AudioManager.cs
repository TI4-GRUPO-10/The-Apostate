using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
using UnityEngine.Audio;
>>>>>>> cdbb466 (LoadScreen)

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Opcional, se quiser que sobreviva a trocas de cena
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
<<<<<<< HEAD
<<<<<<< HEAD
            
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
            
>>>>>>> cdbb466 (LoadScreen)
        }
        else
        {
            Destroy(gameObject);
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public void PlaySound(AudioClip clip, AudioMixerGroup mixerGroup = null)
=======
    public void PlaySound(AudioClip clip)
>>>>>>> c1b9b96 (Soud Track Music)
=======
    public void PlaySound(AudioClip clip, AudioMixerGroup mixerGroup = null)
>>>>>>> cdbb466 (LoadScreen)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
<<<<<<< HEAD
<<<<<<< HEAD
            
            audioSource.outputAudioMixerGroup = mixerGroup; // <<< configurar o mixer aqui
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
            
            audioSource.outputAudioMixerGroup = mixerGroup; // <<< configurar o mixer aqui
>>>>>>> cdbb466 (LoadScreen)
        }
    }
}
