using UnityEngine;

public class grid : MonoBehaviour
{
    public Settings settings;
    private float speed = 0f;
    void Start()
    {
        settings = GetComponentInParent<Settings>();
    }

    void Update()
    {
        speed = settings.tileSpeed;
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
