using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Score scoreScript;
    [SerializeField] SceneChanger sceneChangerScripts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreScript.Addpoints(10);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
        }
    }
}
