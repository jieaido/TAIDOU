using System.Collections.Generic;
using UnityEngine;

public class ServerManger : MonoBehaviour
{
    public ServerBtnProperty greenserver;
    public ServerBtnProperty Redserver;
    public UIGrid ServerUiGrid;
      List<ServerBtnProperty> ServersList=new List<ServerBtnProperty>();

    // Use this for initialization
    private void Start()
    {
        initServer();
        CreateServerBtn();
    }

    private void CreateServerBtn()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
    }

    /// <summary>
    ///     todo 这是临时的生成服务器措施;
    /// </summary>
    private void initServer(int servernum=20)
    {
        ServerBtnProperty sbp;
        for (var i = 0; i < servernum; i++)
        {
            var randomnum = Random.Range(0, 100);

            sbp = randomnum > 50 ? Redserver : greenserver;
            sbp.ServerIP = "127.0.0.1";
            sbp.ServerName="第" + i + "个服务器";
            sbp.ServerPerNum = randomnum;
            ServersList.Add(sbp);
            NGUITools.AddChild(ServerUiGrid.gameObject, sbp.gameObject);
           // ServerUiGrid.AddChild(sbp.transform);
        }
        
    }

    
}