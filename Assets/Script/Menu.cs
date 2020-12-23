using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject panelMenu;
    public bool isMenu;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isMenu = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        animator.SetTrigger("BotonPlayPulsado");
        Time.timeScale = 1;
        isMenu = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
