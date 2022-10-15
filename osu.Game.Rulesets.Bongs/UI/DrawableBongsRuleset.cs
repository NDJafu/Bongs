// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Bongs.Objects;
using osu.Game.Rulesets.Bongs.Objects.Drawables;
using osu.Game.Rulesets.Bongs.Replays;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;

namespace osu.Game.Rulesets.Bongs.UI
{
    [Cached]
    public class DrawableBongsRuleset : DrawableScrollingRuleset<BongsHitObject>
    {
        public DrawableBongsRuleset(BongsRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 6000;
        }

        protected override Playfield CreatePlayfield() => new BongsPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new BongsFramedReplayInputHandler(replay);

        public override DrawableHitObject<BongsHitObject> CreateDrawableRepresentation(BongsHitObject h) => new DrawableBongsHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new BongsInputManager(Ruleset?.RulesetInfo);
    }
}
