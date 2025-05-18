using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSequence : MonoBehaviour
{

    public bool trigger;
    [SerializeField] private Transform lookAt;

    public void setTrigget(bool status)
    {
        trigger = status;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (trigger && lookAt.transform.position.y > -60)
        {
            lookAt.transform.SetPositionAndRotation(new Vector2(lookAt.transform.position.x, lookAt.transform.position.y - 1), lookAt.transform.rotation);
        }
        else if(lookAt.transform.position.y <= -60)
        {
            SceneManager.LoadScene(1,LoadSceneMode.Single);
        }
    }
}
