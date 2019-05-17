using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScripts : MonoBehaviour
{
    public AudioSource sfx;
    public AudioSource bg;
    public AudioClip[] bgMusic;
    public AudioClip gameOver;
    public AudioClip jump;
    public AudioClip hit;
    public AudioClip bounce;
    public AudioClip enemyBounce;
    public AudioClip starPickup;
    void Start()
    {
        bg.clip = bgMusic[Random.Range(0, bgMusic.Length)];
        bg.Play();
    }

    public void playJump()
    {
        sfx.PlayOneShot(jump);
    }
    public void playGameOver()
    {
        sfx.PlayOneShot(gameOver);
    }
    public void playHit()
    {
        sfx.PlayOneShot(hit);
    }
    public void playBounce()
    {
        sfx.PlayOneShot(bounce);
    }
    public void playEnemyBounce()
    {
        sfx.PlayOneShot(enemyBounce);
    }
    public void playGetStar()
    {
        sfx.PlayOneShot(starPickup);
    }
}
