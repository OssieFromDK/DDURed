using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackoutManager : MonoBehaviour
{
    FadeInOut fadeInOutScript;

    private void Start()
    {
        fadeInOutScript = GetComponent<FadeInOut>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "BlackoutTriggerbox")
        {
            fadeInOutScript.fadeInEvent(3f);

            StartCoroutine(SwitchScene());
        }
    }

    private IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(1); // Adventure
    }
}
