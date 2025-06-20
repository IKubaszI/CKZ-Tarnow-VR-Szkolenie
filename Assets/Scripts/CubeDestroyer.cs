using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(collision.gameObject);
            Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
