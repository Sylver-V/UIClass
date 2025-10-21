using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem particleSystemButton;

    public void OnClick()
    {
        particleSystemButton.Play();
    }
}
