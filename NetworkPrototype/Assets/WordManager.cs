using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class WordManager : NetworkBehaviour
{
    static public WordManager instance { get; private set; }

    public List<string> wordList;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
