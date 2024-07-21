using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;

using UnityEngine;
using Verse;

namespace HeadlessCorpseFilter {
    public class SpecialThingFilterWorker_HeadlessCorpse : SpecialThingFilterWorker {
        public override bool Matches(Thing t) {
            Corpse corpse = t as Corpse;
            return corpse.InnerPawn.health.hediffSet.PartIsMissing((BodyPartRecord p) => p.def == BodyPartDefOf.Head)
        }
    }
}


