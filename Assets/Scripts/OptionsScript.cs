using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class OptionsScript : MonoBehaviour
{
    //AUDIO SLIDER
    [SerializeField] AudioClip[] soundtrack;

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider brightness;

    [SerializeField] AudioSource audioSource;
    [SerializeField] Image brightnesspanel;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Initialize
    void Start()
    {
        if (!audioSource.playOnAwake)
        {
            audioSource.Play();
        }

        changeVolume(volumeSlider.value);
    }

    // Update every frame

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // SLIDER EVENT
    private void OnEnable()
    {
        volumeSlider.onValueChanged.AddListener(delegate { changeVolume(volumeSlider.value); });
        brightness.onValueChanged.AddListener(sliderCallBack);
    }

    // Slider Change of VOLUME
    private void changeVolume(float sliderValue)
    {
        audioSource.volume = sliderValue;
    }

    //BRIGHTNESS SLIDER
    void sliderCallBack(float value)
    {
        Debug.Log("Slider Value Changed: " + value);
        brightnesspanel.color = new Color(0,0,0,1.0f-value);
    }

    // Undo Slider Events
    private void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveAllListeners();
        brightness.onValueChanged.RemoveAllListeners();
    }

    //GRAPHICS QUALITY
    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
