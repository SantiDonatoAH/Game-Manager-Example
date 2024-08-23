using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScript : MonoBehaviour
{
    public Text txtScore;
    public Text txtRecord;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = GameManager.Instance.score.ToString("F2");
        txtRecord.text = GameManager.Instance.record.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
