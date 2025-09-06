using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayGame : MonoBehaviour
{
    public string gameSceneName = "MAIN"; // Đặt tên Scene chính
    public AudioSource sfxAudioSource; // Nơi phát SFX
    public AudioClip clickSFX; // Âm thanh click

    public void OnPlayButtonClicked()
    {
        // Phát âm thanh SFX click
        if (sfxAudioSource != null && clickSFX != null)
        {
            sfxAudioSource.PlayOneShot(clickSFX);
        }

        // Load scene game
        SceneManager.LoadScene("MAIN");
    }
}
