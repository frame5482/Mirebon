using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DMG_Xeno : MonoBehaviour
{
    [SerializeField]
    AudioSource SoundSystem;
    public HITBOX_SENA _HITBOX_SENA;
    public AudioClip[] REIaudioClips;
    public void Start_EX()
    {
        _HITBOX_SENA.DMG = 500;

    }
    public void END_EX()
    {
        _HITBOX_SENA.DMG = 100;

    }
    public void Start_Skill3()
    {
        _HITBOX_SENA.DMG = 200;

    }
    public void END_Skill3()
    {
        _HITBOX_SENA.DMG = 100;

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
