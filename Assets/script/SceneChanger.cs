using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string scene1;
    public string scene2;
    public string scene3;
    public string scene;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scene() 
    {  
        SceneManager.LoadScene(scene);  
    }

    public void Scene1() 
    {  
        SceneManager.LoadScene(scene1);  
    }

    public void Scene2() 
    {  
        SceneManager.LoadScene(scene2);  
    }

    public void Scene3() 
    {  
        SceneManager.LoadScene(scene3);  
    }
}
