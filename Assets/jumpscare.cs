using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class jumpscares : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource audioSource;


    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SCare");
        JumpScareImg.SetActive(true);
        audioSource.Play();
        StartCoroutine(DisableImg());
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        JumpScareImg.SetActive(false);
    }
}