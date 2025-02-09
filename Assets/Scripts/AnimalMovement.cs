using Unity.VisualScripting;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    [SerializeField] GameObject lion_animation;
    [SerializeField] GameObject zebra_animation;
    private float speed = 0.5f;
    [SerializeField] private int moveLimit = 12500;
    private int moveCount = 0;
    private int direction = 1;
    private Vector3 zebraStartPos;
    private int zebraLimit = 30;

    private int lionLimit = 10;
    private Vector3 lionStartPos;

    void Start()
    {
        if (zebra_animation != null)
        {
            zebraStartPos = zebra_animation.transform.localPosition;
        }
        if (lion_animation != null)
        {
            lionStartPos = lion_animation.transform.localPosition;
        }

    }
    void Update()
    {
        if (lion_animation != null && moveCount < moveLimit)
        {
            lion_animation.transform.localPosition += Vector3.left * speed * Time.deltaTime * direction;
            if (lion_animation.transform.localPosition.x < -lionLimit || lion_animation.transform.localPosition.x >= lionStartPos.x)
            {
                direction *= -1;
            }
        }
        if (zebra_animation != null)
        {
            zebra_animation.transform.localPosition += Vector3.left * (speed * 4) * Time.deltaTime;
            if (zebra_animation.transform.localPosition.x < -zebraLimit)
            {
                zebra_animation.transform.localPosition = zebraStartPos;
            }
        }
    }

}