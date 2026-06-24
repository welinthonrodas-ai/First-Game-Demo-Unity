using UnityEngine;
using UnityEngine.Audio;
using static UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing;

public class ManagerConfig : MonoBehaviour
{

    public AudioMixer AudioMix;

    public void SetVolument(float volumen)
    {
        AudioMix.SetFloat("volumen", volumen);
    }

    public void FullScreen(bool SetFullScreen)
    {
        
        Screen.fullScreen = SetFullScreen;
    }

    public void Graficos(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }


}
