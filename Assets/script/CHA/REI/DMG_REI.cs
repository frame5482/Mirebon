using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DMG_REI : MonoBehaviour
{
    [SerializeField]
    AudioSource SoundSystem;
    public HITBOX_REI _HITBOX_REI;
    public AudioClip[] REIaudioClips;
    public void Start_EX()
    {
        _HITBOX_REI.DMG = 1000;

    }
    public void END_EX()
    {
        _HITBOX_REI.DMG = 100;

    }
    public void Start_Skill2()
    {
        _HITBOX_REI.DMG = 500;

    }
    public void END_Skill2()
    {
        _HITBOX_REI.DMG = 100;

    }
    public void SoundAttack()
    {
        SoundSystem.PlayOneShot(REIaudioClips[0]);
    }
    public void SoundEX()
    {
        SoundSystem.PlayOneShot(REIaudioClips[1]);
    }

}
