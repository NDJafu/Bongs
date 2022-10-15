using osu.Game.Rulesets.Bongs.Scoring;

namespace osu.Game.Rulesets.Bongs.Scoring
{
    public class BongsHitWindows
    {
        private static readonly DifficultyRange[] bong_ranges =
        {
            new DifficultyRange(HitResult.Great, 50, 35, 20),
            new DifficultyRange(HitResult.OK, 120, 80, 50),
            new DifficultyRange(HitResult.Miss, 135, 95, 70),
        };
        public override bool IsHitResultAllowed(HitResult result)
        {
            switch (result)
            {
                case HitResult.Great:
                case HitResult.OK:
                case HitResult.Miss:
                    return true;
            }


            return false;
        }
        protected override DifficultyRange[] GetRanges() => bong_ranges;
    }
}
