using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class menus : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI points;
    public Button instructions;
    public AudioSource audioMenu;
    public AudioSource audioGame;

    // Start is called before the first frame update
    void Start()
    {
        audioGame.Stop();
        audioMenu.Play();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {

            audioMenu.Stop();
            SceneManager.LoadScene("game");

            audioGame.Play();
        }

     
    }



}
