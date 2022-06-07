using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu_script : MonoBehaviour {
    
    public GameObject creditsPanel;

    void Start(){
        creditsPanel.SetActive(false);
    }

    public void play_button(){
        SceneManager.LoadScene("SampleScene");
    }

    public void back_button(){
        creditsPanel.SetActive(false);
    }

    public void credits_button(){
        creditsPanel.setActive(true);
    }

    public void quit_button(){
        Application.Quit();
    }

}


