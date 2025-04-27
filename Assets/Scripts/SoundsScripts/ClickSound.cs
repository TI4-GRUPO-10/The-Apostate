using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.Audio;
=======
>>>>>>> c1b9b96 (Soud Track Music)

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;

<<<<<<< HEAD
    public AudioMixerGroup mixerGroup;
    
=======
>>>>>>> c1b9b96 (Soud Track Music)
    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PlayClickSound);
        }
<<<<<<< HEAD

=======
>>>>>>> c1b9b96 (Soud Track Music)
    }

    void PlayClickSound()
    {
<<<<<<< HEAD
        if (clickSound != null && mixerGroup != null)
        {
            AudioManager.Instance.PlaySound(clickSound, mixerGroup);
=======
        if (clickSound != null)
        {
            AudioManager.Instance.PlaySound(clickSound);
>>>>>>> c1b9b96 (Soud Track Music)
        }
    }
}
