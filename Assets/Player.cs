using UnityEngine;

public class Player : MonoBehaviour
{
    public Settings settings;
    public AnimationCurve posCurve;
    public float targetTime = 0;

    private bool isAlive = true;
    private bool isMoving = false;
    
    private float targetY = -2.5f;
    private float startY = -2.5f;
    private float timeY = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isAlive && !isMoving)
        {
            startY = this.transform.position.y;
            targetY += 1;
            isMoving = true;
            timeY = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && isAlive && isMoving)
        {
            transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
            startY = this.transform.position.y;
            targetY += 1;
            isMoving = true;
            timeY = 0f;
        }
        if (transform.position.y == targetY)
        {
            isMoving = false;
        }
        if (isMoving && isAlive)
        {
            timeY += Time.deltaTime;
            transform.position = new Vector3(transform.position.x, startY + posCurve.Evaluate(timeY / targetTime), transform.position.z);
        }
        if (transform.position.y > 3f)
        {
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);
            targetY = -2.5f;
            startY = -3.5f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.transform.tag == "Tile")
        {
            isAlive = false;
            settings.EndGame();
            this.GetComponent<Collider2D>().enabled = false;
            this.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
    }
}
