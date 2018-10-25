namespace DreamOfStars.Events
{
    public sealed class SaveGameStateEvent : IEvent
    {
        public SaveGameStateEvent() : this(0)
        {

        }

        public SaveGameStateEvent(int saveSlot)
        {
            SaveSlot = saveSlot;
        }

        public int SaveSlot { get; private set; }
    }
}
