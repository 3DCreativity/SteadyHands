using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{

    [SerializeField] private string key;

    public void CallDialogue()
    {
        DialogueManager.Instance.StartDialogue(key);
        gameObject.SetActive(false);
    }
}
