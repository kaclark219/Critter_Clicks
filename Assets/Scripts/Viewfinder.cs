using UnityEngine;

public class Viewfinder : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    void Start()
    {

    }

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = -4.95f;
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
