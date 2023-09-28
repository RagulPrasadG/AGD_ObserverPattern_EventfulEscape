using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] int keyRequiredToTrigger;
    [SerializeField] SoundType soundType;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && GameService.Instance.GetPlayerController().KeysEquipped == keyRequiredToTrigger)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundType);
            this.enabled = false;
        }
    }
}