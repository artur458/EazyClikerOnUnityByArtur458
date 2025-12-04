using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerMenanger : MonoBehaviour
{
    [Header("Texts")]
    public Text scoreText;
    public Text clickText;
    [Header("Sounds")]
    public AudioSource clickSound;
    public AudioSource paySound;

    private int score = 0;
    private int click = 1;

    public void OnClick()
    {
        score += click;
        clickSound.Play();
    }
    public void UpdCl(int Cl)
    {
        if (score >= Cl * 10)
        {
            score -= Cl * 10;
            click += Cl;
            paySound.Play();
        }
    }
    public void Udv(int UdvScore)
    {
        if (score >= UdvScore)
        {
            score -= UdvScore;
            score *= 2;
            paySound.Play();
        }
    }
    private void Update()
    {
        scoreText.text = score.ToString() + "$";
        clickText.text = click.ToString() + " кликов";
    }
}
