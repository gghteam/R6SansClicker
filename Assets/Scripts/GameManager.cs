using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private Text textScore;

    private string jsonString = "";

    private string filePath = "";

    private void Awake()
    {
        player = new Player();     
        filePath = string.Concat(Application.persistentDataPath, "/", "Save.txt");
        OnClickLoad();
        UpdateUI();
        Debug.Log("filePath : " + filePath);
    }

    public void OnClick()
    {
        player.union += player.unionPerClick;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (textScore == null) return;
        textScore.text = string.Format("{0} UNION", player.union);
    }

    public void OnClickSave()
    {
        jsonString = JsonUtility.ToJson(player);
        FileStream fs = new FileStream(filePath, FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(jsonString);
        fs.Write(data, 0, data.Length);
        fs.Close();
        Debug.Log("JSON : " + jsonString);
    }

    public void OnClickLoad() 
    {
        FileStream fs = new FileStream(filePath, FileMode.Open);
        byte[] data = new byte[fs.Length];
        fs.Read(data, 0, data.Length);
        fs.Close();
        jsonString = Encoding.UTF8.GetString(data);
        player = JsonUtility.FromJson<Player>(jsonString);

        UpdateUI();
    }
}
