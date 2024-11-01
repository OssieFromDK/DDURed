using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJumpScare : MonoBehaviour
{
    public GameObject GirlObject;
    private GameObject spawnedGirl;

    private bool hasShown = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "JumpscareBox")
        {
            SceneManager.LoadScene(2);
        }

        if(other.gameObject.name == "ShowBox" && !hasShown)
        {
            hasShown = true;
            spawnedGirl = Instantiate(GirlObject, new Vector3(193.988998f, 0f, 161.837006f), new Quaternion(0f, -0.909961283f, 0f, 0.414693326f));
            StartCoroutine(BlinkGirl());
        }
    }

    private IEnumerator BlinkGirl()
    {
        spawnedGirl.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        spawnedGirl.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        spawnedGirl.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        spawnedGirl.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        spawnedGirl.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        spawnedGirl.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        spawnedGirl.SetActive(false);
    }

}
