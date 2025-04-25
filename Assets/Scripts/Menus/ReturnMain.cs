using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMain : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
