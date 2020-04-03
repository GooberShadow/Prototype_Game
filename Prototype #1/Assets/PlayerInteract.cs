using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public Talk npc;

    private void OnCollisionStay(Collision collision)
    {
        //npc.NPCIsTalking();
        if (Input.GetKey("e"))
        {
            Debug.Log("TALKING");
        }
    }
}
