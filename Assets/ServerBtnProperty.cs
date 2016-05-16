using UnityEngine;
using System.Collections;

public class ServerBtnProperty : MonoBehaviour
{

    public string ServerIP;

    public string ServerName
    {
        get { return ServerName; }
        set { GetComponentInChildren<UILabel>().text = value; }
    }

    private string _servername;
    public int ServerPerNum;
    private UILabel ServerLabel;



    // Use this for initialization
    void Start()
    {
        

    }

    public void Awake()
    {
       
    }

    // Update is called once per frame
    public void changeServerName(string servername)
    {
        ServerName = servername;
        _servername = ServerName;
        if (ServerLabel != null)
        {
            ServerLabel.text = servername;
        }
    }
}
