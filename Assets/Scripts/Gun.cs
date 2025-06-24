using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Ustawienia pocisku")]
    public float bulletSpeed = 40f;
    public GameObject bulletPrefab;
    public Transform barrel;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip shotSound;

    // Funkcja wywoływana z Interactable Event (Activate -> Activated)
    public void Fire()
    {
        // 1) Tworzymy pocisk w punkcie Barrel
        GameObject spawned = Instantiate(bulletPrefab, barrel.position, barrel.rotation);

        // 2) Nadajemy mu prędkość w kierunku lufy
        Rigidbody rb = spawned.GetComponent<Rigidbody>();
        rb.linearVelocity = barrel.forward * bulletSpeed;

        // 3) Odtwarzamy dźwięk strzału
        audioSource.PlayOneShot(shotSound);

        // 4) Sprzątamy po 10 sekundach
        Destroy(spawned, 10f);
    }
}
