using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    public int targetscore = 3;

    public TextMesh text;

    public int currentLevel = 0;
    
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="Level: " + currentLevel + " Score: " + score + " Target: " + targetscore;
        
        if (score == targetscore)
        {
            currentLevel++;
            GetComponent<AudioSource>().Play();
            targetscore += targetscore + targetscore/2;
        }
    }
}
