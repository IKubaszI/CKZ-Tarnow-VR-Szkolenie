using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // przechowuje liczbę punktów
    public TMP_Text scoreText; // referencja do tekstu na ekranie
    public GameObject cubePrefab; // prefab nowej kostki
    public Transform spawnPoint; // miejsce, gdzie ma się pojawić nowa kostka
    public AudioSource pointSound; // dźwięk odtwarzany przy zdobyciu punktu

    private void Start()
    {
        scoreText.text = "Score: 0";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Destroy(other.gameObject); // usuń starą kostkę
            score++; // zwiększ wynik
            scoreText.text = "Score: " + score; // zaktualizuj tekst
            Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity); // stwórz nową kostkę
            pointSound.Play(); // odtwórz dźwięk
        }
    }
}
