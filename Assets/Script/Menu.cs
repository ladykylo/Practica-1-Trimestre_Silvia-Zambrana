using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        animator.SetTrigger("BotonPlayPulsado");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
