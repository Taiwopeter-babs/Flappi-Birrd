using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLogic : MonoBehaviour
{


    public void StartNewGame()
    {
        Scene mainScene = SceneManager.GetSceneByName("FlappiAssets");

        AsyncOperation operation = SceneManager.LoadSceneAsync("FlappiAssets", LoadSceneMode.Single);

        if (operation.isDone)
        {
            SceneManager.SetActiveScene(mainScene);
        }
    }
}
