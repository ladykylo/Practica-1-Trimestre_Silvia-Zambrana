using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plataformas : MonoBehaviour
{
    public float speed = 5f;
    public Transform myPosotion;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
