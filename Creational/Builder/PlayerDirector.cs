namespace Builder
{
    internal class PlayerDirector
    {
        public Player BuildPlayer(IPlayerBuilder builder)
        {
            builder.AddPlayButton();
            builder.StopPlayButton();
            return builder.BuildPlayer();
        }
    }
}
