public class EventService
{
    private static EventService _instance;
    public static EventService Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new EventService();
            }
            return _instance;
        }
    }

    public EventController onLightToggledEvent { get; private set; }

    public EventService()
    {
        onLightToggledEvent = new EventController();
    }
    
}
