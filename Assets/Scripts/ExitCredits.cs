using UnityEngine;
using UnityEngine.UI;

public class ExitCredits : MonoBehaviour
{
    public Button quitButton;
    public GameObject credits;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitBtnClicked()
    {
        if (credits != null)
        {
            credits.SetActive(false);
        }
    }
}
