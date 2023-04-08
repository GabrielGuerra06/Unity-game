using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class cube : MonoBehaviour
{
    public float velocidad;
    public GameObject prefab;
    public AudioSource audioEnemy;
    public AudioSource audioFruit;
    public TextMeshProUGUI points;
    public static int score=1;

    public Material[] material;
    public int x;
    Renderer rend;

    public AudioSource audioWin;
    public AudioSource audioLose;
    // Start is called before the first frame update
    void Start()
    {
        points.text = "SCORE: " + score;
        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled= true;
        rend.sharedMaterial = material[x];
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        
        points.text = "SCORE: " + score;

    }

void movement()
    {
     

        if (Input.GetKey(KeyCode.A) && transform.position.x < 92)
        {
            transform.Translate(0.1f, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.D) && transform.position.x > 82)
        {
            transform.Translate(-0.1f, 0f, 0f);
        }

    }
    public void nextColor()
    {
        if (x < 2)
        {
            x++;
        }
        else
        {
            x = 0;
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
       

        if (score <= 0)
        {
            SceneManager.LoadScene("Lose");
            score = 1;
            
        }
        else if (score > 0 && score <15)
        {
            if (other.name == "Mon_00(Clone)")
            {
                score -= 1;
                audioEnemy.Play();
                nextColor();
                rend.sharedMaterial = material[x];
                
            }
            else if (other.name == "apple(Clone)" || other.name == "peach(Clone)" || other.name == "cherries(Clone)")
            {
                score += 1;
                print(score);
                audioFruit.Play();
                nextColor();
                rend.sharedMaterial = material[x];
                
            }
        }
        else if(score >= 15)
        {
            SceneManager.LoadScene("Win");
            score = 1;
            
        }
    
        
    }


}
