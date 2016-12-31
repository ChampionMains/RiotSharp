namespace RiotSharp.CurrentGameEndpoint.Enums
{
    /// <summary>
    /// queueType and gameQueueConfigId subtype of CurrentGame API
    /// </summary>
    public static class GameQueueType
    {
        /// <summary>
        /// Custom games.
        /// </summary>
        public const string Custom = "CUSTOM";

        /// <summary>
        /// Normal 3v3 games.
        /// </summary>
        public const string Normal3x3 = "NORMAL_3x3";

        /// <summary>
        /// Normal 5v5 Blind Pick games.
        /// </summary>
        public const string Normal5x5Blind = "NORMAL_5x5_BLIND";

        /// <summary>
        /// Normal 5v5 Draft Pick games.
        /// </summary>
        public const string Normal5x5Draft = "NORMAL_5x5_DRAFT";

        /// <summary>
        /// Ranked Solo 5v5 games, deprecated.
        /// </summary>
        public const string RankedSolo5x5 = "RANKED_SOLO_5x5";

        /// <summary>
        /// Ranked Premade 5v5 games, deprecated.
        /// </summary>
        public const string RankedPremade5x5 = "RANKED_PREMADE_5x5";

        /// <summary>
        /// Used for historyical Ranked Premade 3v3 games. Replaced by RankedFlexTT.
        /// </summary>
        public const string RankedPremade3x3 = "RANKED_PREMADE_3x3";

        /// <summary>
        /// Used for current Ranked Flex Twisted Treeline games.
        /// </summary>
        public const string RankedFlexTT = "RANKED_FLEX_TT";

        /// <summary>
        /// Ranked Team 3v3 games, deprecated.
        /// </summary>
        public const string RankedTeam3x3 = "RANKED_TEAM_3x3";

        /// <summary>
        /// Ranked Team 5v5 games.
        /// </summary>
        public const string RankedTeam5x5 = "RANKED_TEAM_5x5";

        /// <summary>
        /// Dominion 5v5 Blind Pick games.
        /// </summary>
        public const string Odin5x5Blind = "ODIN_5x5_BLIND";

        /// <summary>
        /// Dominion 5v5 Draft Pick games.
        /// </summary>
        public const string Odin5x5Draft = "ODIN_5x5_DRAFT";

        /// <summary>
        /// Historical Summoner's Rift Coop vs AI games, deprecated.
        /// </summary>
        public const string Bot5x5 = "BOT_5x5";

        /// <summary>
        /// Dominion Coop vs AI games.
        /// </summary>
        public const string BotOdin5x5 = "BOT_ODIN_5x5";

        /// <summary>
        /// Summoner's Rift Coop vs AI Intro Bot games.
        /// </summary>
        public const string Bot5x5Intro = "BOT_5x5_INTRO";

        /// <summary>
        /// Summoner's Rift Coop vs AI Beginner Bot games.
        /// </summary>
        public const string Bot5x5Beginner = "BOT_5x5_BEGINNER";

        /// <summary>
        /// Historical Summoner's Rift Coop vs AI Intermediate Bot games.
        /// </summary>
        public const string Bot5x5Intermediate = "BOT_5x5_INTERMEDIATE";

        /// <summary>
        /// Twisted Treeline Coop vs AI games.
        /// </summary>
        public const string BotTt3x3 = "BOT_TT_3x3";

        /// <summary>
        /// Team Builder games.
        /// </summary>
        public const string GroupFinder5x5 = "GROUP_FINDER_5x5";

        /// <summary>
        /// ARAM games.
        /// </summary>
        public const string Aram5x5 = "ARAM_5x5";

        /// <summary>
        /// One for All games.
        /// </summary>
        public const string Oneforall5x5 = "ONEFORALL_5x5";

        /// <summary>
        /// Snowdown Showdown 1v1 games.
        /// </summary>
        public const string Firstblood1x1 = "FIRSTBLOOD_1x1";

        /// <summary>
        /// Snowdown Showdown 2v2 games.
        /// </summary>
        public const string Firstblood2x2 = "FIRSTBLOOD_2x2";

        /// <summary>
        /// Summoner's Rift 6x6 Hexakill games.
        /// </summary>
        public const string Sr6x6 = "SR_6x6";

        /// <summary>
        /// Ultra Rapid Fire games.
        /// </summary>
        public const string Urf5x5 = "URF_5x5";

        /// <summary>
        /// One for All (Mirror mode).
        /// </summary>
        public const string OneForAllMirrorMode = "ONEFORALL_MIRRORMODE_5x5";

        /// <summary>
        /// Ultra Rapid Fire games played against AI games.
        /// </summary>
        public const string BotUrf5x5 = "BOT_URF_5x5";

        /// <summary>
        /// Doom Bots Rank 1 games.
        /// </summary>
        public const string NightmareBot5x5Rank1 = "NIGHTMARE_BOT_5x5_RANK1";

        /// <summary>
        /// Doom Bots Rank 2 games.
        /// </summary>
        public const string NightmareBot5x5Rank2 = "NIGHTMARE_BOT_5x5_RANK2";

        /// <summary>
        /// Doom Bots Rank 5 games.
        /// </summary>
        public const string NightmareBot5x5Rank5 = "NIGHTMARE_BOT_5x5_RANK5";

        /// <summary>
        /// Ascension games.
        /// </summary>
        public const string Ascension5x5 = "ASCENSION_5x5";

        /// <summary>
        /// Twisted Treeline 6x6 Hexakill games.
        /// </summary>
        public const string Hexakill = "HEXAKILL";

        /// <summary>
        /// Butcher's Bridge games.
        /// </summary>
        public const string BilgewaterAram5x5 = "BILGEWATER_ARAM_5x5";

        /// <summary>
        /// King Poro games.
        /// </summary>
        public const string KingPoro5x5 = "KING_PORO_5x5";

        /// <summary>
        /// Nemesis games.
        /// </summary>
        public const string CounterPick = "COUNTER_PICK";

        /// <summary>
        /// Black Market Brawlers games.
        /// </summary>
        public const string Bilgewater5x5 = "BILGEWATER_5x5";

        /// <summary>
        /// Nexus Siege games.
        /// </summary>
        public const string Siege = "SIEGE";

        /// <summary>
        /// Definitely Not Dominion games.
        /// </summary>
        public const string DefinitelyNotDominion5x5 = "DEFINITELY_NOT_DOMINION_5x5";

        /// <summary>
        /// All Random URF games.
        /// </summary>
        public const string ARURF5x5 = "ARURF_5x5";

        /// <summary>
        /// Normal 5v5 Draft Pick games.
        /// </summary>
        public const string TeamBuilderDraftUnranked5x5 = "TEAM_BUILDER_DRAFT_UNRANKED_5x5";

        /// <summary>
        /// Ranked 5v5 Draft Pick games, deprecated.
        /// </summary>
        public const string TeamBuilderDraftRanked5x5 = "TEAM_BUILDER_DRAFT_RANKED_5x5";

        /// <summary>
        /// Ranked Solo games from current season that use Team Builder matchmaking.
        /// </summary>
        public const string TeamBuilderRankedSolo = "TEAM_BUILDER_RANKED_SOLO";

        /// <summary>
        /// Ranked Flex Summoner's Rift games.
        /// </summary>
        public const string RankedFlexSR = "RANKED_FLEX_SR";
    }
}
