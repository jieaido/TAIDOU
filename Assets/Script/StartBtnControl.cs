using UnityEngine;
using System.Collections;

public class StartBtnControl : MonoBehaviour
{

    public TweenScale StartTweenScale;
    public TweenScale LoginTweenScale;
    public TweenScale RegsiterTweenScale;
    public TweenScale ServerChoiceScale;
    public UIInput UsernameInput;
    public UIInput PwdInput;
    public UILabel UserNameLabel;
    public UIInput RegisterInput;
    public UILabel ServerBtnLabel;
    public void OnUserNameBtnClick()
    {
        ScollPanel(LoginTweenScale,StartTweenScale);



        
    }
    public void OnloginCloseBtnClick()
    {
        ScollPanel(StartTweenScale,LoginTweenScale);

    }

    public void OnLoginBtnClick()
    {
        //todo  等到用户名密码存储起来
        string username = UsernameInput.value;
        string pwd = PwdInput.value;
        //todo 需要验证用户名密码 返回开始界面
        ScollPanel(StartTweenScale,LoginTweenScale);


        UserNameLabel.text = username;

    }

    public void OnRegisterBtnClick()
    {

        ScollPanel(RegsiterTweenScale,LoginTweenScale);

    }

    public void OnRegisterCancalBtnClick()
    {

        ScollPanel(StartTweenScale,RegsiterTweenScale);
    }

    public void OnRegisterLoginBtnClick()
    {
        //todo 需要处理注册处理程序
        string username = RegisterInput.value;



            ScollPanel(StartTweenScale,RegsiterTweenScale);
        UserNameLabel.text = username;


    }
    IEnumerator  HidePanel(GameObject go)
    {
        yield return new WaitForSeconds(0.4f);
        go.SetActive(false);
    }

    public   void ScollPanel(UITweener beShowTweener, UITweener behideTweener)
    {       
        behideTweener.PlayReverse();
        StartCoroutine(HidePanel(behideTweener.gameObject));
        beShowTweener.gameObject.SetActive(true);
        beShowTweener.PlayForward();
    }

    public void OnServerBtnClick()
    {
        ScollPanel(ServerChoiceScale,StartTweenScale);
    }

    public void OnServerCloseClick()
    {
        ScollPanel(StartTweenScale, ServerChoiceScale);
        ServerBtnLabel.text = ServerManger.SelectServer._servername;
    }
}
