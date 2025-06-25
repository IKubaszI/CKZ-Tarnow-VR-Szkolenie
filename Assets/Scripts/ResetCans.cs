using UnityEngine;
public class ResetCans : MonoBehaviour
{
    public GameObject[] canPrefabs;
    public Transform[] spawnPoints;

    public void RespawnCans()
    {
        // usuń wszystkie obecne puszki
        foreach (var oldCan in GameObject.FindGameObjectsWithTag("Can"))
        {
            Destroy(oldCan);
        }

        // losowo wybierz i ustaw nowe puszki
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int rand = Random.Range(0, canPrefabs.Length);
            Instantiate(canPrefabs[rand], spawnPoints[i].position, Quaternion.identity);
        }
    }
}
