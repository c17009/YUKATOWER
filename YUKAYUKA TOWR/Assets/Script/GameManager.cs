using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int count;
    public Text nakano;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0) count = 0;
        nakano.text = count.ToString();
        //transform.Translate(new Vector2(0, 5));
    }

    public void CameraUp()
    {
        transform.Translate(new Vector2(0, 5));
        print("UP");
    }

    public void GotoGame()
    {
        SceneManager.LoadScene("Main");
    }
}
