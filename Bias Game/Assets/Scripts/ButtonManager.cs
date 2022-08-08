using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public GameObject canvas;

    public void ActivateObject(GameObject _object) {
        string _tag = _object.tag;
        DisableTaggedObject(_tag);
        StartCoroutine(SetActive(_object));
    }

    public IEnumerator SetActive(GameObject _object) {
        yield return new WaitForSeconds(0.01f);
        _object.SetActive(true);
    }

    public void ShowImage(GameObject _object) {
        string _tag = _object.tag;
        HideImage(_tag);
        _object.GetComponent<Image>().enabled = true;
    }

    GameObject[] gameObjects;
    private void DisableTaggedObject(string tag) {
        gameObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject target in gameObjects) {
            target.SetActive(false);
        }
    }

    private void HideImage(string tag) {
        gameObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject target in gameObjects) {
            target.GetComponent<Image>().enabled = false;
        }
    }
}
