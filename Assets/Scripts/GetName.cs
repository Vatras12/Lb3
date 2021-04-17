using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    [SerializeField] private InputField InputField1;
    //[Header("Keys")]
    //[SerializeField] private string saveNameKey = "NAME_VALUE";

    JSONController json = new JSONController();
    void Start()
    {
        json.LoadField();
        InputField1.text = json.item.Name;
        //InputField1.text = PlayerPrefs.GetString(saveNameKey);
    }

    void Update()
    {
        json.item.Name = InputField1.text;
        json.SaveField();
        //PlayerPrefs.SetString(saveNameKey,InputField1.text);
    }
}
