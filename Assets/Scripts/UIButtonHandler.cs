using UnityEngine;
using TMPro;

public class UIButtonHandler : MonoBehaviour
{
    public GameObject targetObject;      // CubeTarget
    public Material colorBlue;           // Blue1
    public Material colorRed;            // Red1
    public TMP_Text infoText;            // napis info
    public TMP_Text scoreText;           // licznik z konspektu 5
    public GameObject cubePrefab;        // prefab kostki
    public Transform spawnPoint;         // miejsce spawnu
    public AudioSource spawnSound;       // dźwięk spawnu

    private bool useBlue = true;

    public void ChangeColor()            // Btn_Color
    {
        var rend = targetObject.GetComponent<Renderer>();
        rend.material = useBlue ? colorRed : colorBlue;
        useBlue = !useBlue;
    }

    public void ShowInfo()               // Btn_Info
    {
        if (infoText) infoText.text = "START!";
    }

    public void SpawnCube()
{
    GameObject newCube = Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);

    if (newCube.TryGetComponent(out Renderer rend))
        rend.material = useBlue ? colorBlue : colorRed;

    if (spawnSound)
        spawnSound.Play();
}


public void ChangeFontSize(float v)
{
    if (scoreText != null)
    {
        scoreText.enableAutoSizing = false;
        scoreText.fontSize = Mathf.Max(10f, v);  // minimalna wartość 10
    }
}

}
