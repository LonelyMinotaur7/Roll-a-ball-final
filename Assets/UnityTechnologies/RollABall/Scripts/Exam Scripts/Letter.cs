using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    [SerializeField] private List<GameObject> letters;

    private char initial;
    
    
    // Start is called before the first frame update
    void Start()
    {

        initial = Char.ToLower(Name.NameRaw[0]);

        /*for (int i = 0; i < letters.Count; i++)
        {
            if(i)
        }*/

        GameObject prefab = Instantiate(letters[(int)initial - 97]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
