using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;


public class Scan : MonoBehaviour
{
    public GameObject backGround;
    public GameObject scanButton;
    public GameObject backButton;
    public GameObject welcomeText;
    public GameObject scanText;

    public void OnButtonClick()
    {
        backGround.SetActive(false);
        scanButton.SetActive(false);
        backButton.SetActive(true);
        welcomeText.SetActive(false);
        scanText.SetActive(false);

    }

    public void OnButtonClickBack()
    {
        backGround.SetActive(true);
        scanButton.SetActive(true);
        backButton.SetActive(false);
        welcomeText.SetActive(true);
        scanText.SetActive(true);
    } 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
