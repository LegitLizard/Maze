using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : MonoBehaviour
{
    public GameObject Player;
    public Transform Target;
    public GameObject CrawlerObj;
    public Animator CrawlerMove;
    public GameObject Attack;
    public GameObject AttackView;
    public Animator CrawlerAttack;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        CrawlerObj.GetComponent<SkinnedMeshRenderer>().enabled = false;
        temp = Player.transform.position;
        //temp.x = temp.x + 2;
        Attack.transform.position = Player.transform.position;
        AttackView.GetComponent<SkinnedMeshRenderer>().enabled = true;
        CrawlerAttack.SetTrigger("Attack");
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("body"))
        {
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    { 
        CrawlerObj.GetComponent<SkinnedMeshRenderer>().enabled = false;
        temp = Player.transform.position;
        //temp.x = temp.x + 2;
        Attack.transform.position = Player.transform.position;
        AttackView.GetComponent<SkinnedMeshRenderer>().enabled = true;
        CrawlerAttack.SetTrigger("Attack");
        //audioSource.PlayOneShot(clip, volume);
        yield return new WaitForSecondsRealtime(3);
        //Player.transform.position = Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
