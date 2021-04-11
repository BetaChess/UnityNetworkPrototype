using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkTest : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!hasAuthority)
            return;

        Cmd_sendWord("TEST" + netId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ////////////////// COMMANDS
    ///
    [Command]
    void Cmd_sendWord(string word)
    {
        WordManager.instance.wordList.Add(word);
        Rpc_sendWord(word);
    }

    ////////////////// RPCS
    ///
    [ClientRpc]
    void Rpc_sendWord(string word)
    {
        WordManager.instance.wordList.Add(word);
    }
}
