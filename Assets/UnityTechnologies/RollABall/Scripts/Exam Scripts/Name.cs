using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{
    public TMP_InputField NameInput;

    public static string NameRaw;

    private int mode = 0;

    public GameObject disc1;
    public GameObject disc2;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReadStringInput(string s)
    {
        NameRaw = NameInput.text;
        Debug.Log(NameRaw);
        if (mode == 1)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
    }


    public void ModeSwap()
    {
        mode = 1;
        
        disc1.SetActive(true);
        disc2.SetActive(true);
    }
}
