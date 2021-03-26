using System.Collections;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator[] animators;
    private Animator animator;
    int randomAnim;
    public int animationTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        randomAnim = Random.Range(0, 4);
        animator = GetComponent<Animator>();
        animator.SetInteger("AnimNumber", randomAnim);
        StartCoroutine(DrugayAnimation(animationTime));
    }

    IEnumerator DrugayAnimation(int sec)
    { int tempRandom;
        while (true)
        {
            yield return new WaitForSeconds(sec);
            tempRandom = Random.Range(0, 4);
            while (tempRandom == randomAnim)
                 {
                  tempRandom = Random.Range(0, 4);
                 }

            randomAnim = tempRandom;
            animator.SetInteger("AnimNumber", randomAnim);

        }
    }

}
