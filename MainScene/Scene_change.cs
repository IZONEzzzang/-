using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Story");
    }
    public void ChangeGameOption()
    {
        SceneManager.LoadScene("Option");
    }

        
}
