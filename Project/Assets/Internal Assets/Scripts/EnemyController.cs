using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject Player;
    private bool isAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < 1.2f) {
            if (isAttack == true) return; 
            gameObject.GetComponent<Animator>().Play("Attack");
            isAttack = true;
            Destroy(gameObject,2.5f);
        }
        if (isAttack == false) {
            gameObject.transform.LookAt(Player.transform.position);
        }
    }


    public void HitPlayer() {
        GameObject damage = Instantiate(Resources.Load("get_damage")) as GameObject;
        damage.transform.position = Player.gameObject.transform.position + Vector3.up;
        Player.GetComponent<PlayerInteraction>().Health += -10;
        Player.GetComponent<PlayerController>().GetHit();
    }
}
