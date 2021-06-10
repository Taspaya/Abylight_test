using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AsyncLoad : MonoBehaviour
{
    // Start is called before the first frame update
    AsyncOperation loadingOperation;
    void Start()
    {
        Resources.UnloadUnusedAssets();
        loadingOperation = SceneManager.LoadSceneAsync(FlowManager.Instance.nextSceneToLoad);
    }

    // Update is called once per frame
    void Update()
    {
        float loadProgress = loadingOperation.progress;
        Debug.Log(loadProgress);
    }


}
