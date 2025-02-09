using UnityEngine;

public class GiraffeChecker : MonoBehaviour
{
    public bool giraffeInRange;

    void Start()
    {
        giraffeInRange = false;
    }

    void Update()
    {

    }
    public void GiraffeRangeTrue()
    {
        giraffeInRange = true;
    }
    public void GiraffeRangeFalse()
    {
        giraffeInRange = false;
    }
}
