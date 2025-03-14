using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public Canvas confirmationbox;
    public Button playText;
    public Button exitButton;
    public Button cancelText;
    public Button exitText;
    public Canvas exitCanvas;

    // Start is called before the first frame update
    void Start()
    {
        confirmationbox.enabled = false;
        exitCanvas.enabled = true;
        playText = playText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pressPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void pressYes()
    {
        Application.Quit();
    }
    public void pressNo()
    {
        exitText.enabled = true;
        playText.enabled = true;
        confirmationbox.enabled = false;
        exitCanvas.enabled = true;
    }
    public void confirmBox()
    {
        exitText.enabled = false;
        playText.enabled = false;
        exitCanvas.enabled = false;
        confirmationbox.enabled = true;
    }
}
