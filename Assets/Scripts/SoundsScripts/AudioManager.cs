using UnityEngine;
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)

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
            
=======
>>>>>>> c1b9b96 (Soud Track Music)
        }
        else
        {
            Destroy(gameObject);
        }
    }

<<<<<<< HEAD
    public void PlaySound(AudioClip clip, AudioMixerGroup mixerGroup = null)
=======
    public void PlaySound(AudioClip clip)
>>>>>>> c1b9b96 (Soud Track Music)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
<<<<<<< HEAD
            
            audioSource.outputAudioMixerGroup = mixerGroup; // <<< configurar o mixer aqui
=======
>>>>>>> c1b9b96 (Soud Track Music)
        }
    }
}
