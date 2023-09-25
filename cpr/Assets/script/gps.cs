using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class LocationSender : MonoBehaviour
{
    public string phpScriptURL = "http://localhost/unitybackendTutorial/connect.php";  // 替換為您的 PHP 腳本的實際 URL

    public void SendLocation(double latitude, double longitude)
    {
        StartCoroutine(PostLocation(latitude, longitude));
    }

    private IEnumerator PostLocation(double latitude, double longitude)
    {
        // 創建要傳遞的表單數據
        WWWForm form = new WWWForm();
        form.AddField("Latitude", latitude.ToString());
        form.AddField("longitude", longitude.ToString());

        // 創建 POST 請求
        UnityWebRequest www = UnityWebRequest.Post(phpScriptURL, form);

        // 發送請求並等待回應
        yield return www.SendWebRequest();

        // 檢查是否有錯誤
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("POST 請求失敗: " + www.error);
        }
        else
        {
            Debug.Log("POST 請求成功，伺服器回應：" + www.downloadHandler.text);
        }
    }
}
