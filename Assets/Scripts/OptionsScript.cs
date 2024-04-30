using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class OptionsScript : MonoBehaviour
{
    //AUDIO SLIDER
    [SerializeField] AudioClip[] soundtrack;
    [SerializeField] Slider volumeSlider;

    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Initialize
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();

        if (!audioSource.playOnAwake)
        {
            audioSource.Play();
        }
    }

    // Update every frame

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Register Slider Events
    private void OnEnable()
    {
        volumeSlider.onValueChanged.AddListener(delegate { changeVolume(volumeSlider.value); });
    }

    // Called with Slider Change
    private void changeVolume(float sliderValue)
    {
        audioSource.volume = sliderValue;
    }

    // Undo Slider Events
    private void OnDisable()
    {
        volumeSlider.onValueChanged.RemoveAllListeners();
    }



    //BRIGHTNESS SLIDER


    //GRAPHICS QUALITY
    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
