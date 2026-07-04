using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters.Enemies.DLC6;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_e4a8da10672dd15489d1023ebb4c9264_d39e5dd766134c29b02fe5019da61822 : IntBinding
	{
		private EME_TeleporterBoss CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (int, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((int, AbsoluteSimulationFrame));
		}

		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return null;
		}
	}
}
