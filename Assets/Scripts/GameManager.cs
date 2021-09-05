using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text NameField;
    public static new string name;
    // Start is called before the first frame update
    void Start()
    {
        name = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        name = NameField.text.ToString();
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("main");
    }
}
