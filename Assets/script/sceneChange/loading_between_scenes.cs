using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading_between_scenes : MonoBehaviour {

    public Slider slider;
    bool IsDone = false;
    float fTime = 0f;
    AsyncOperation async_operation;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartLoad("Test3"));
	}
	
	// Update is called once per frame
	void Update () {
        fTime += Time.deltaTime;
        slider.value = fTime;

        if(fTime >= 2)
        {
            async_operation.allowSceneActivation = true;
        }
	}

    public IEnumerator StartLoad(string stSceneName)
    {
        async_operation = Application.LoadLevelAsync("Test3");
        async_operation.allowSceneActivation = false;

        if(IsDone == false)
        {
            IsDone = true;

            while (async_operation.progress < 0.9f)
            {
                slider.value = async_operation.progress;

                yield return true;
            }
        }
    }
}
