using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SavannaController : MonoBehaviour
{
    public Transform viewfinder;
    public float range = 1f;

    [SerializeField] GameObject bird;
    [SerializeField] GameObject zebra;
    [SerializeField] GameObject elephant;
    [SerializeField] GameObject lion;
    [SerializeField] GameObject giraffe;
    [SerializeField] GameObject hippo;
    public GameObject[] animals;
    private Dictionary<GameObject, bool> photographedAnimals = new Dictionary<GameObject, bool>();

    [SerializeField] HippoChecker hippoChecker;
    [SerializeField] GiraffeChecker giraffeChecker;
    [SerializeField] BirdChecker birdChecker;

    [SerializeField] GameObject hippoPhoto;
    [SerializeField] GameObject giraffePhoto;
    [SerializeField] GameObject lionPhoto;
    [SerializeField] GameObject elephantPhoto;
    [SerializeField] GameObject zebraPhoto;
    [SerializeField] GameObject birdPhoto;

    [SerializeField] GameObject instructions;
    private bool instrPressed = false;
    [SerializeField] GameObject winPage;

    [SerializeField] AudioSource pictureSound;
    [SerializeField] AudioSource photobookSound;

    [SerializeField] Timer timerScript;
    [SerializeField] TextMeshProUGUI finalTimeText;
    bool haveTime = false;


    void Start()
    {
        instructions.SetActive(true);

        foreach (GameObject animal in animals)
        {
            photographedAnimals[animal] = false;
        }

        hippoPhoto.SetActive(false);
        giraffePhoto.SetActive(false);
        lionPhoto.SetActive(false);
        elephantPhoto.SetActive(false);
        zebraPhoto.SetActive(false);
        birdPhoto.SetActive(false);
        winPage.SetActive(false);

        timerScript.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.anyKey && !instrPressed)
        {
            instrPressed = true;
            instructions.SetActive(false);
            timerScript.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            CheckAnimalsInRange();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            photobookSound.Play();
            ShowAnimalsInRange();
        }
        if (WinCondition() == true)
        {
            if (haveTime == false)
            {
                haveTime = true;
                float winTime = timerScript.elapsedTime;
                finalTimeText.text = "Final Time: " + winTime.ToString("F2");
            }

            winPage.SetActive(true);
        }
    }
    
    public void CheckAnimalsInRange()
    {
        if (viewfinder != null)
        {
            foreach (GameObject animal in animals)
            {
                float distance = Vector3.Distance(animal.transform.position, viewfinder.position);
                if (distance <= range && !photographedAnimals[animal])
                {
                    if (animal == zebra || animal == elephant)
                    {
                        Debug.Log(animal.name + " was captured in the photo!");
                        photographedAnimals[animal] = true;
                        pictureSound.Play();
                    }
                    if ((animal == lion) && (animal.transform.localPosition.x < -8.4))
                    {
                        Debug.Log(animal.name + " was captured in the photo!");
                        photographedAnimals[animal] = true;
                        pictureSound.Play();
                    }
                    if (animal == hippo)
                    {
                        if (hippoChecker.hippoInRange == true)
                        {
                            Debug.Log(animal.name + " was captured in the photo!");
                            photographedAnimals[animal] = true;
                            pictureSound.Play();
                        }
                    }
                    if (animal == giraffe)
                    {
                        if (giraffeChecker.giraffeInRange == true)
                        {
                            Debug.Log(animal.name + " was captured in the photo!");
                            photographedAnimals[animal] = true;
                            pictureSound.Play();
                        }
                    }
                    if (animal == bird)
                    {
                        if (birdChecker.birdInRange == true)
                        {
                            Debug.Log(animal.name + " was captured in the photo!");
                            photographedAnimals[animal] = true;
                            pictureSound.Play();
                        }
                    }
                }
                else if (distance <= range && photographedAnimals[animal])
                {
                    Debug.Log(animal.name + " has already been photographed.");
                }
            }
        }
    }
    public void ShowAnimalsInRange()
    {
        foreach (GameObject animal in animals)
        {
            if (animal == hippo && photographedAnimals[animal])
            {
                hippoPhoto.SetActive(!hippoPhoto.activeSelf);
            }
            if (animal == giraffe && photographedAnimals[animal])
            {
                giraffePhoto.SetActive(!giraffePhoto.activeSelf);
            }
            if (animal == lion && photographedAnimals[animal])
            {
                lionPhoto.SetActive(!lionPhoto.activeSelf);
            }
            if (animal == elephant && photographedAnimals[animal])
            {
                elephantPhoto.SetActive(!hippoPhoto.activeSelf);
            }
            if (animal == zebra && photographedAnimals[animal])
            {
                zebraPhoto.SetActive(!hippoPhoto.activeSelf);
            }
            if (animal == bird && photographedAnimals[animal])
            {
                birdPhoto.SetActive(!hippoPhoto.activeSelf);
            }
        }
    }

    public bool WinCondition()
    {
        bool checker = true;
        foreach (GameObject animal in animals)
        {
            if (false == photographedAnimals[animal])
            {
                checker = false;
            }
        }
        return checker;
    }
}
