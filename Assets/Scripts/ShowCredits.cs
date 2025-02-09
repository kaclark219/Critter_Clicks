using UnityEngine;
using UnityEngine.UI;

public class ShowCredits : MonoBehaviour
{
    public GameObject credits;
    public Button btn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        credits.SetActive(false);
        btn.onClick.AddListener(creditsClicked);
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    public void creditsClicked()
    {
        if (credits != null)
        {
            credits.SetActive(!credits.activeSelf);
        }
    }
}