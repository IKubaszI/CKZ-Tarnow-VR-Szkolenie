using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CanHitSound : MonoBehaviour
{
    public string projectileTag = "Bullet";
    private AudioSource audioSrc;

    private void Awake()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(projectileTag))
            audioSrc.Play();
    }
}
