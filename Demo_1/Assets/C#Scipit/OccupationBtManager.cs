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
            // ���� ����
            isCapturing = true;
            Txt_Occupation.text = "���� ��";
            Bt_Occupation.interactable = false; // ��ư ��Ȱ��ȭ
            Txt_status.text = "���� A�÷��̾ ���� ���̿���.";
        }
    }

    public void StopCapturing()
    {
        if (isCapturing)
        {
            // ���� ����
            isCapturing = false;
            Txt_Occupation.text = "�����ϱ�";
            Bt_Occupation.interactable = true; // ��ư Ȱ��ȭ
            Txt_status.text = "���� B�÷��̾ ���� ���̿���.";
        }
    }
}
