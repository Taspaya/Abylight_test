using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    private static FlowManager instance;
    public static FlowManager Instance
    {
        get
        {
            return instance;
        }
    }

    private bool created;
    public string nextSceneToLoad = "InGame";

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("FlowManager");

        if (objs.Length > 1 && !created)
        {
            Destroy(gameObject);
        }
        else
        {
            created = true;
            DontDestroyOnLoad(gameObject);

            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        GoToMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void GoToInit() { }
    public void GoToMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void GoToInGame() { }
}
