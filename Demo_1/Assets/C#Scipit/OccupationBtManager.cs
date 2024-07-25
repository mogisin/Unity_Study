using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OccupationManager : MonoBehaviour
{
    public Button Bt_Occupation;
    public Text Txt_Occupation;
    public Text Txt_status;
    private bool isCapturing = false;

    // Start is called before the first frame update
    void Start()
    {
        Bt_Occupation.onClick.AddListener(OnCapturing);
    }

    // Update is called once per frame
    void OnCapturing()
    {
        if (!isCapturing)
        {
            // 점령 시작
            isCapturing = true;
            Txt_Occupation.text = "점령 중";
            Bt_Occupation.interactable = false; // 버튼 비활성화
            Txt_status.text = "현재 A플레이어가 점령 중이에요.";
        }
    }

    public void StopCapturing()
    {
        if (isCapturing)
        {
            // 점령 중지
            isCapturing = false;
            Txt_Occupation.text = "점령하기";
            Bt_Occupation.interactable = true; // 버튼 활성화
            Txt_status.text = "현재 B플레이어가 점령 중이에요.";
        }
    }
}
