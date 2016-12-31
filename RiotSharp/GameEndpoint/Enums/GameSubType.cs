namespace RiotSharp.GameEndpoint.Enums
{
    /// <summary>
    /// Game subtype of the game (Game API).
    /// </summary>
    public static class GameSubType
    {
        /// <summary>
        /// Custom games.
        /// </summary>
        public const string None = "NONE";

        /// <summary>
        /// Summoner's Rift unranked games.
        /// </summary>
        public const string Normal = "NORMAL";

        /// <summary>
        /// Summoner's Rift and Crystal Scar games played against AI.
        /// </summary>
        public const string Bot = "BOT";

        /// <summary>
        /// Summoner's Rift ranked solo queue games.
        /// </summary>
        public const string RankedSolo5x5 = "RANKED_SOLO_5x5";

        /// <summary>
        /// Twisted treeline ranked premade games.
        /// </summary>
        public const string RankedPremade3x3 = "RANKED_PREMADE_3x3";

        /// <summary>
        /// Summoner's rift ranked premade games.
        /// </summary>
        public const string RankedPremade5x5 = "RANKED_PREMADE_5x5";

        /// <summary>
        /// Dominion/Crystal Scar games.
        /// </summary>
        public const string OdinUnranked = "ODIN_UNRANKED";

        /// <summary>
        /// Twisted Treeline ranked team games.
        /// </summary>
        public const string RankedTeam3x3 = "RANKED_TEAM_3x3";

        /// <summary>
        /// Summoner's Rift ranked team games.
        /// </summary>
        public const string RankedTeam5x5 = "RANKED_TEAM_5x5";

        /// <summary>
        /// Twisted Treeline unranked games.
        /// </summary>
        public const string Normal3x3 = "NORMAL_3x3";

        /// <summary>
        /// Twisted Treeline games played against AI.
        /// </summary>
        public const string Bot3x3 = "BOT_3x3";

        /// <summary>
        /// ARAM/Howling Abyss games.
        /// </summary>
        public const string AramUnranked5x5 = "ARAM_UNRANKED_5x5";

        /// <summary>
        /// One for All games.
        /// </summary>
        public const string OneForAll5x5 = "ONEFORALL_5x5";

        /// <summary>
        /// Snowdown Showdown 1x1 games.
        /// </summary>
        public const string FirstBlood1x1 = "FIRSTBLOOD_1x1";

        /// <summary>
        /// Snowdown Showdown 2x2 games.
        /// </summary>
        public const string FirstBlood2x2 = "FIRSTBLOOD_2x2";

        /// <summary>
        /// Hexakill games
        /// </summary>
        public const string Hexakill = "HEXAKILL";

        /// <summary>
        /// Team Builder games.
        /// </summary>
        public const string TeamBuilder5x5 = "CAP_5x5";

        /// <summary>
        /// URF games
        /// </summary>
        public const string URF = "URF";

        /// <summary>
        /// URF Bots games
        /// </summary>
        public const string URFBots = "URF_BOT";

        /// <summary>
        /// Nightmare bots games.
        /// </summary>
        public const string NightmareBot = "NIGHTMARE_BOT";

        /// <summary>
        /// Ascension mode games.
        /// </summary>
        public const string Ascension = "ASCENSION";

        /// <summary>
        /// King Poro games.
        /// </summary>
        public const string KingPoro = "KING_PORO";

        /// <summary>
        /// Counter Pick games.
        /// </summary>
        public const string CounterPick = "COUNTER_PICK";

        /// <summary>
        /// Black Market Brawlers games.
        /// </summary>
        public const string Bilgewater = "BILGEWATER";

        /// <summary>
        /// Ranked Flex Twisted Treeline games.
        /// </summary>
        public const string RankedFlexTT = "RANKED_FLEX_TT";

        /// <summary>
        /// Ranked Flex Summoner's Rift games.
        /// </summary>
        public const string RankedFlexSR = "RANKED_FLEX_SR";

        /// <summary>
        /// Nexus Siege games.
        /// </summary>
        public const string Siege = "SIEGE";

        /// <summary>
        /// Summoner's Rift 6x6 Hexakill games
        /// </summary>
        public const string SR6x6 = "SR_6x6";
    }
}
