using UnityEngine;

public class ChangeAnimatorStage : MonoBehaviour
{
    public GameObject targetObject; // The target GameObject
    public AnimationClip animationClip; // The animation clip to play

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject && animationClip != null)
        {
            // Play the assigned animation clip
            Animation targetAnimation = targetObject.GetComponent<Animation>();
            if (targetAnimation != null)
            {
                targetAnimation.clip = animationClip;
                targetAnimation.Play();
            }
            else
            {
                Debug.LogWarning("No Animation component found on the target object.");
            }
        }
    }
}
