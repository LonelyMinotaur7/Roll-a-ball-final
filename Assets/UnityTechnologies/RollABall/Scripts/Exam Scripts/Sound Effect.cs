using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public float minPitch = .8f, maxPitch = 1.2f;


    private float pitchMax;
    private AudioSource soundGO;

    void Start()
    {
        soundGO = GetComponent<AudioSource>();

        pitchMax = Random.Range(minPitch, maxPitch);

        soundGO.pitch = pitchMax;
    }
}
