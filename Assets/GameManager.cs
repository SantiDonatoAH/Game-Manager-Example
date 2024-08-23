using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    public static GameManager Instance;
    public int lives = 3;
    public float score = 0f;
    public float record = 3f;

    private void Awake()
=======

    public static GameManager Instance; 


    void Awake()
>>>>>>> d74853b1db356194c1af6ee79fd30058f1952575
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

<<<<<<< HEAD
=======
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeScene("Game");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeScene("Menu");
        }
    }
>>>>>>> d74853b1db356194c1af6ee79fd30058f1952575

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
<<<<<<< HEAD
=======

    
>>>>>>> d74853b1db356194c1af6ee79fd30058f1952575
}
