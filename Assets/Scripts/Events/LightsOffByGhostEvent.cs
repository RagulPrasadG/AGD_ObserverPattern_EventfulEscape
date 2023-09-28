using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] int keyRequiredToTrigger;
    [SerializeField] SoundType soundType;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>() != null && keyRequiredToTrigger == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundType);
            //this.enabled = false this code fails to disable the script and event is triggering twice
            this.gameObject.SetActive(false);
        }
    }
}