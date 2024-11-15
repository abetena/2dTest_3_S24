using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownPlayerAnimation : MonoBehaviour
{
    //Taking the animator and playground's Move component
    private Animator animator;
    private Move move;

    // Start is called before the first frame update
    void Start()
    {
        //activate Animator and Move
        if (!animator)
        { animator = GetComponent<Animator>(); }
        else
        {
            Debug.Log("I don't have an animator!");
        }

        if (!move)
        { move = GetComponent<Move>(); }
        else
        {
            Debug.Log("I don't have a Move!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Take the horizontal and vertical values of "Move" and use them to
        //determine the floating parameters in the animator "horizonatAnim" & "verticalAnim"
        animator.SetFloat("horizonatAnim", move.moveHorizontal);
        animator.SetFloat("verticalAnim", move.moveVertical);

    }
}
