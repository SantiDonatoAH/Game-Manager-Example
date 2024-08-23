using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    public void OnButtonGamePressed(string value)
    {
        GameManager.Instance.ChangeScene(value);
    }
    
}
