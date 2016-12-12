using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BasicFirearm : MonoBehaviour
{
    public float fireRate = 0.3F;
    public float damage = 10;
    public AudioClip weaponSound;

    float timeToNextShot = 0;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Time.time >= timeToNextShot && Input.GetButton("Fire1"))
        {
            audioSource.PlayOneShot(weaponSound, 1.0F);
            timeToNextShot = Time.time + fireRate;
        }
    }
}
