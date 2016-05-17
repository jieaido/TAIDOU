using UnityEngine;
using System.Collections;

public class ServerBtnProperty : MonoBehaviour
{

    public string ServerIP;
    public ServerManger sm;

    public string ServerName
    {
        get { return _servername; }
        set
        {
            _servername = value;
            GetComponentInChildren<UILabel>().text = value;
          
        }
    }

    public   string _servername;
    public int ServerPerNum;




    // Use this for initialization

    // Update is called once per frame
//    public void changeServerName(string servername)
//    {
//        ServerName = servername;
//        _servername = ServerName;
//        if (ServerLabel != null)
//        {
//            ServerLabel.text = servername;
//        }
//    }
    public void OnServerBtnClick()
    {
        ServerManger.SelectServer = this;
        sm.go.GetComponent<UIButton>().normalSprite = this.GetComponent<UIButton>().normalSprite;
        sm.go.GetComponentInChildren<UILabel>().text = this.GetComponentInChildren<UILabel>().text;
        sm.go.GetComponentInChildren<UILabel>().color = this.GetComponentInChildren<UILabel>().color;
    }
}
