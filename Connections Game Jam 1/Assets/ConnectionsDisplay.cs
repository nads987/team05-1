using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//display the current amount of connections
public class ConnectionsDisplay : MonoBehaviour
{
    public int connections = 0;
    public Text connecText;
    

    // Update is called once per frame
    void Update()
    {
        connecText.text = "CONNECTIONS: " + connections;
    }
}
