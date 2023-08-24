﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;

namespace Grimforge
{
    public class CompProperties_NeedEnergyTracker : CompProperties
    {
        public CompProperties_NeedEnergyTracker()
        {
            compClass = typeof(NeedEnergyTrackerComp);
        }


        //Don't think I'll use these, keeping them just in case
        //public float maxEnergy
        //public float drainRateModifier = 1f;
        //public float powerNetDrainRate = 1.32f;
        //public int ticksSpentCharging = 300;
        //public JobDef hibernationJob;
    }
}