using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PositionsUI : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI PositionText;
    private void Start()
    {
        player = GameObject.Find("Ship").transform;
    }
    // Update is called once per frame
    void Update()
    {
        PositionText.text = "x:" + player.position.x.ToString("0") + " y:" + player.position.y.ToString("0") + " z:" + player.position.z.ToString("0");
    }
}
