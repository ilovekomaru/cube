using TMPro;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float tileSpeed = 1.0f;
    public float speedMultiplyer = 0.0001f;
    public float maxSpeed = 5f;
    public float endGameSpeed = 0.5f;

    private bool endGame = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (!endGame)
        {
            tileSpeed = Mathf.Clamp(tileSpeed + Time.time * speedMultiplyer, 0, maxSpeed);
            score.text = Time.time.ToString("F1");
        }
        
        if (endGame)
        {
            tileSpeed = Mathf.Clamp(tileSpeed - endGameSpeed * Time.deltaTime, 0, maxSpeed);
        }
        if (Time.time < 2f)
        {
            tileSpeed = 5f - Time.time * 2;
        }
    }

    public void EndGame()
    {
        endGame = true;
    }
}
