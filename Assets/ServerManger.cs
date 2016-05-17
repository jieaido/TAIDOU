using System.Collections.Generic;
using UnityEngine;

public class ServerManger : MonoBehaviour
{
    public ServerBtnProperty Greenserver;
    public ServerBtnProperty Redserver;
    public UIGrid ServerUiGrid;
      List<ServerBtnProperty> ServersList=new List<ServerBtnProperty>();
    public  GameObject go;

    public static ServerBtnProperty SelectServer ;

    // Use this for initialization
    private void Start()
    {
        initServer(15);
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

            sbp = randomnum > 50 ? Redserver : Greenserver;
            GameObject go= NGUITools.AddChild(ServerUiGrid.gameObject, sbp.gameObject);
            ServerBtnProperty sbp2 = go.GetComponent<ServerBtnProperty>();
            sbp2.ServerIP = "127.0.0.1";
            sbp2.ServerName="第" + i + "个服务器";
            sbp2.ServerPerNum = randomnum;
            sbp2.sm = this;
            ServersList.Add(sbp);

           // ServerUiGrid.AddChild(sbp.transform);
        }
        
    }

    
    
}