using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNPC : MonoBehaviour
{
    [SerializeField] GameObject npc;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject npc_change = Instantiate(npc, this.transform.position, Quaternion.identity);
            CatchType("head", npc_change);
            CatchType("body", npc_change);
            //CatchType("hat", npc_change);
        }
    }

    private void CatchType(string type, GameObject npc_change)
    {
        GameObject obj;
        switch (type)
        {
            case "head":
                obj = npc_change.GetComponentInChildren<Head>().gameObject;
                break;
            case "body":
                obj = npc_change.GetComponentInChildren<Body>().gameObject;
                break;
            default:
                obj = npc_change.GetComponentInChildren<Hat>().gameObject;
                break;
        }
        Show(obj);
    }

    private void Show(GameObject obj)
    {
        Style[] styles = obj.GetComponentsInChildren<Style>();
        int style = Random.Range(0, 2);
        for (int i = 0; i < styles.Length; i++)
        {
            if (i == style)
            {
                continue;
            }
            styles[i].gameObject.SetActive(false);
        }
    }
}
