using UnityEngine;

public class BirdChecker : MonoBehaviour
{
    public bool birdInRange;

    void Start()
    {
        birdInRange = false;
    }

    void Update()
    {

    }
    public void BirdRangeTrue()
    {
        birdInRange = true;
    }
    public void BirdRangeFalse()
    {
        birdInRange = false;
    }
}
