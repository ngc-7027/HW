namespace HW_Tic_Tac_Toe
{
    public class Player
    {
        public char Symbol { get; set; }
        public string Name { get; set; }

        static public (Player activePlayer, Player waitingPlayer) SwitchPlayer(Player activePlayer, Player waitingPlayer)
        {
            (Player activePlayer, Player waitingPlayer) switchedPlyers = (waitingPlayer, activePlayer);
            return switchedPlyers;
        }
    }
}
