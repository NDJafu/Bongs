// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Bongs.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Bongs.Replays
{
    public class BongsAutoGenerator : AutoGenerator<BongsReplayFrame>
    {
        public new Beatmap<BongsHitObject> Beatmap => (Beatmap<BongsHitObject>)base.Beatmap;

        public BongsAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new BongsReplayFrame());

            foreach (BongsHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new BongsReplayFrame
                {
                    Time = hitObject.StartTime
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}
