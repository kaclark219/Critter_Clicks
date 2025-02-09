using UnityEngine;

public class HippoChecker : MonoBehaviour
{
    public bool hippoInRange;

    void Start()
    {
        hippoInRange = false;
    }

    void Update()
    {
        
    }
    public void HippoRangeTrue()
    {
        hippoInRange = true;
    }
    public void HippoRangeFalse()
    {
        hippoInRange = false;
    }
}
