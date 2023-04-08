using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class changeScene : MonoBehaviour
{



    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
 
    }

    void Update()
    {
      
        if (Input.GetMouseButton(0))
        {
            LoadScene("Instructions");
        }
       
    }

}
