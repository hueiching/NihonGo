using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class autoSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public double timer;
    public string scene;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
