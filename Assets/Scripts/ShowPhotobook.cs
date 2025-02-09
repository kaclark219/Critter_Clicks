using UnityEngine;

public class ShowPhotobook : MonoBehaviour
{
    public GameObject photobook;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        photobook.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (photobook != null)
            {
                photobook.SetActive(!photobook.activeSelf);
            }
        }
    }
}
