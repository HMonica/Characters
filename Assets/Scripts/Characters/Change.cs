using System;
using UnityEngine;


public class Change : MonoBehaviour
{
    int selectedCharacterIndex = 1;
    string characterName, character, prevcharacter;

    void Start()
    {
        GameObject.Find("1").transform.Find("C1").gameObject.SetActive(true);
        GameObject.Find("2").transform.Find("C2").gameObject.SetActive(false);
        GameObject.Find("3").transform.Find("C3").gameObject.SetActive(false);
        GameObject.Find("4").transform.Find("C4").gameObject.SetActive(false);
        GameObject.Find("5").transform.Find("C5").gameObject.SetActive(false);
    }

    public void LeftButton()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex == 0)
            selectedCharacterIndex = 5;
    }
    public void RightButton()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == 6)
            selectedCharacterIndex = 1;
    }

    void Update()
    {
    
        switch (selectedCharacterIndex)
        {
            case 1:
                GameObject.Find("1").transform.Find("C1").gameObject.SetActive(true);
                GameObject.Find("2").transform.Find("C2").gameObject.SetActive(false);
                GameObject.Find("3").transform.Find("C3").gameObject.SetActive(false);
                GameObject.Find("4").transform.Find("C4").gameObject.SetActive(false);
                GameObject.Find("5").transform.Find("C5").gameObject.SetActive(false);
            break;

            case 2:
                GameObject.Find("1").transform.Find("C1").gameObject.SetActive(false);
                GameObject.Find("2").transform.Find("C2").gameObject.SetActive(true);
                GameObject.Find("3").transform.Find("C3").gameObject.SetActive(false);
                GameObject.Find("4").transform.Find("C4").gameObject.SetActive(false);
                GameObject.Find("5").transform.Find("C5").gameObject.SetActive(false);
            break;

            case 3:
                GameObject.Find("1").transform.Find("C1").gameObject.SetActive(false);
                GameObject.Find("2").transform.Find("C2").gameObject.SetActive(false);
                GameObject.Find("3").transform.Find("C3").gameObject.SetActive(true);
                GameObject.Find("4").transform.Find("C4").gameObject.SetActive(false);
                GameObject.Find("5").transform.Find("C5").gameObject.SetActive(false);
            break;

            case 4:
                GameObject.Find("1").transform.Find("C1").gameObject.SetActive(false);
                GameObject.Find("2").transform.Find("C2").gameObject.SetActive(false);
                GameObject.Find("3").transform.Find("C3").gameObject.SetActive(false);
                GameObject.Find("4").transform.Find("C4").gameObject.SetActive(true);
                GameObject.Find("5").transform.Find("C5").gameObject.SetActive(false);
            break;

            case 5:
                GameObject.Find("1").transform.Find("C1").gameObject.SetActive(false);
                GameObject.Find("2").transform.Find("C2").gameObject.SetActive(false);
                GameObject.Find("3").transform.Find("C3").gameObject.SetActive(false);
                GameObject.Find("4").transform.Find("C4").gameObject.SetActive(false);
                GameObject.Find("5").transform.Find("C5").gameObject.SetActive(true);
            break;
        }
    }
}
