using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
using UnityEngine.Audio;
>>>>>>> cdbb466 (LoadScreen)

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;

<<<<<<< HEAD
<<<<<<< HEAD
    public AudioMixerGroup mixerGroup;
    
=======
>>>>>>> c1b9b96 (Soud Track Music)
=======
    public AudioMixerGroup mixerGroup;
    
>>>>>>> cdbb466 (LoadScreen)
    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PlayClickSound);
        }
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> c1b9b96 (Soud Track Music)
=======

>>>>>>> cdbb466 (LoadScreen)
    }

    void PlayClickSound()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        if (clickSound != null && mixerGroup != null)
        {
            AudioManager.Instance.PlaySound(clickSound, mixerGroup);
=======
        if (clickSound != null)
        {
            AudioManager.Instance.PlaySound(clickSound);
>>>>>>> c1b9b96 (Soud Track Music)
=======
        if (clickSound != null && mixerGroup != null)
        {
            AudioManager.Instance.PlaySound(clickSound, mixerGroup);
>>>>>>> cdbb466 (LoadScreen)
        }
    }
}
