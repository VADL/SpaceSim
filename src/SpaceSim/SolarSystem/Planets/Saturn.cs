﻿using System.Drawing;
using SpaceSim.Kernels;
using SpaceSim.Orbits;
using SpaceSim.Physics;
using VectorMath;

namespace SpaceSim.SolarSystem.Planets
{
    class Saturn : MassiveBodyBase
    {
        public override double Mass
        {
            get { return 5.6836e26; }
        }

        public override double SurfaceRadius
        {
            get { return SymbolKernel.SATURN_RADIUS; }
        }

        public override double AtmosphereHeight
        {
            get { return SymbolKernel.SATURN_ATMOSPHERE; }
        }

        public override double RotationRate
        {
            get { return -1.70553347100423085692868e-4; }
        }

        public override double RotationPeriod
        {
            get { return 36840; }
        }

        public override Color IconColor { get { return Color.Gold; } }
        public override Color IconAtmopshereColor { get { return Color.Goldenrod; } }

        public override double BoundingRadius
        {
            get { return SurfaceRadius + SymbolKernel.SATURN_RING_END; }
        }

        public Saturn()
            : base(OrbitHelper.GetPosition(1.3526e12, 1.6132416870058, DVector2.Zero),
                   OrbitHelper.GetVelocity(1.3526e12, 1.6132416870058, -1.018e4, DVector2.Zero), new SaturnKernel())
        {
        }

        public override string ToString()
        {
            return "Saturn";
        }
    }
}
