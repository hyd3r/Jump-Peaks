using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScript : MonoBehaviour
{
    private Animator anim;
    public  Movement move;
    int state = 1;
    public Difficulty diff;
    bool once = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Tutorial", 1) == 0)
        {
            transform.gameObject.SetActive(false);
        }
        else
        {
            move.stunned = true;
            if ((Input.GetAxisRaw("Horizontal") > 0 || move.rightDown)&& !once)
            {
                StartCoroutine(delayStateChange(false));
            }
            if ((Input.GetAxisRaw("Horizontal") < 0 || move.leftDown)&&!once)
            {
                StartCoroutine(delayStateChange(true));
            }
            if (Input.GetButtonDown("Jump")||move.jumpDown)
            {
                PlayerPrefs.SetInt("Tutorial", 0);
                move.stunned = false;
                diff.playGame();
                transform.gameObject.SetActive(false);
            }
        }
    }
    IEnumerator delayStateChange(bool isLeft)
    {
        once = true;
        if (isLeft)
        {
            switch (state)
            {
                case 1: state = 1; break;
                case 2: state = 1; break;
                case 3: state = 2; break;
            }
            anim.SetInteger("TutorialState", state);
        }
        else
        {
            switch (state)
            {
                case 1: state = 2; break;
                case 2: state = 3; break;
                case 3: state = 3; break;
            }
            anim.SetInteger("TutorialState", state);
        }
        yield return new WaitForSeconds(0.5f);
        once = false;
    }
    
}
