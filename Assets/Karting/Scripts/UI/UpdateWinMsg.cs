using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateWinMsg : MonoBehaviour
{

    private TextMeshProUGUI msg;

    private string template = "Tell the prettiest iOS developer @ Grab SG, ";

    void Start() {
        msg = GameObject.Find("WinMsg").GetComponent<TextMeshProUGUI>();
    }
    public void Yes() {
        msg.text = template + "\"See? Someone will be my lobster.\"";
        DestroyBtns();
    }

    public void No() {
        msg.text = template + "\"Joey doesn't share food!\"";
        DestroyBtns();
    }

    private void DestroyBtns() {
        Destroy(GameObject.Find("YesButton"));
        Destroy(GameObject.Find("NoButton"));
    }
}
