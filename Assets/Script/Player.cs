using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour

{

    public float speed = 5f;
    public float jumpPower = 50f;

    [Range(3, 8)]
 
    public Text scoreText;
    public Text highScoreText;
    private float horizontal;
    private bool jump;
    

    private Rigidbody2D myRigidBody2D;
    private int score = 0;
    private int highScore = 0;
    

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();

        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = "Highscore: " + highScore + "";
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))                           //Moverse derecha
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (PlayerPrefs.GetInt("highScore") < score)
        {
            PlayerPrefs.SetInt("highScore", score);                 // Para guardar los puntos maximos.
        }

        horizontal = Input.GetAxis("Horizontal");                   //Para rotar cuando cambie de dirreción

        if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(4f, 4f, 4f);
        }

        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(-4f, 4f, 4f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && GroundCheck.ground) // Comprobar si esta saltando y si esta tocando el suelo.
        {
            jump = true;
        }

        if (jump) // Hacer el salto al comprobar que ha saltado
        {
            myRigidBody2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }

    }

    

    private void OnTriggerEnter2D(Collider2D other)        // Suma de los puntos.
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

}

   

 