using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] GameObject player;

    [Header("Jump")]
    [SerializeField] AudioClip jumpClip;
    [SerializeField] [Range(0f, 1f)] float jumpVolume = 1f;

    [Header("Attack")]
    [SerializeField] AudioClip attackClip;
    [SerializeField] [Range(0f, 1f)] float attackVolume = 1f;

    [Header("Get Hit")]
    [SerializeField] AudioClip hitClip;
    [SerializeField] [Range(0f, 1f)] float hitVolume = 1f;

    [Header("Pickup Coin")]
    [SerializeField] AudioClip coinClip;
    [SerializeField] [Range(0f, 1f)] float coinVolume = 1f;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void PlayJumpClip(){
        PlayClip(jumpClip, jumpVolume);
    }

    public void PlayAttackClip(){
        PlayClip(attackClip, attackVolume);
    }

    public void PlayHitClip(){
        PlayClip(hitClip, hitVolume);
    }
    
    public void PlayCoinClip(){
        PlayClip(coinClip, coinVolume);
    }

    void PlayClip(AudioClip clip, float volume){
        if(clip != null){
            Vector3 playerPos = player.transform.position;
            AudioSource.PlayClipAtPoint(clip, playerPos, volume);
        }
    }
}
