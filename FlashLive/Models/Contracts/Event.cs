using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashLive.Models.Contracts
{
    public abstract class Event : IEvent
    {
        public string EventId { get; set; }
        public long StartTime { get; set; }
        public long StartTimeUtc { get; set; }
        public EventStageType StageType { get; set; }
        public EventStageType MergeStageType { get; set; }
        public EventStage Stage { get; set; }
        public string Sort { get; set; }
        public string Round { get; set; }
        public int VisibleRunRate { get; set; }
        public int HasLineps { get; set; }
        public long StageStartTime { get; set; }
        public string GameTime { get; set; }
        public string ShortNameAway { get; set; }
        public string[] AwayParticipantIds { get; set; }
        public int[] AwayParticipantTypes { get; set; }
        public string AwayName  { get; set; }
        public string AwayParticipantNameOne  { get; set; }
        public string AwayEventParticipantId  { get; set; }
        public int Winner  { get; set; }
        public int OddsWinner  { get; set; }
        public int OddsWinnerOutcome  { get; set; }
        public int AwayGoalVar  { get; set; }
        public string AwayScoreCurrent  { get; set; }
        public string[] AwayImages  { get; set; }
        public string IMM  { get; set; }
        public string IMW  { get; set; }
        public string IMP  { get; set; }
        public string IME  { get; set; }
        public string ShortNameHome  { get; set; }
        public string[] HomeParticipantIds  { get; set; }
        public int[] HomeParticipantTypes  { get; set; }
        public string HomeName  { get; set; }
        public string HomeParticipantNameOne  { get; set; }
        public string HomeEventParticipantId  { get; set; }
        public int HomeGoalVar  { get; set; }
        public string HomeScoreCurrent  { get; set; }
        public string[] HomeImages  { get; set; }
        public int HasLiveCentre  { get; set; }
    }
}
