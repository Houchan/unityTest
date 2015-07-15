using UnityEngine;
using System.Collections;

public class JSONTest : MonoBehaviour {

    //必須ではないらしい
    //[System.Serializable]
    private class DecodeData
    {
        public string message;
        public int num;
        public double dummy;
    }

	// Use this for initialization
	void Start () {

        //仮のJSONテキスト.
        string jsonText = "{\"message\":\"SampleText\",\"num\":1}";

        //JSONテキストのデコード.
        LitJson.JsonData jsonData =  LitJson.JsonMapper.ToObject(jsonText);

        //データの取得
        string message = (string)jsonData["message"];
        int num = (int)jsonData["num"];

        //出力して確認する-1.
        print(message + "," + num);

        //Deserializeする.
        DecodeData decodeData = LitJson.JsonMapper.ToObject<DecodeData>(jsonText);

        //データを更新する.
        decodeData.message += "plus";
        decodeData.num += 1;

        //出力して確認する-2.
        print(decodeData.message + "," + decodeData.num);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
