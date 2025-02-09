using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float elapsedTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        timerText.text = elapsedTime.ToString("F2");
        
    }
}
