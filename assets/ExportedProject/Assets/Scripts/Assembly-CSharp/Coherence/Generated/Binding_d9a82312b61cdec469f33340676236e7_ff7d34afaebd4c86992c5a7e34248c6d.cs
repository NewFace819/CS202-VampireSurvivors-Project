using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_d9a82312b61cdec469f33340676236e7_ff7d34afaebd4c86992c5a7e34248c6d : StringBinding
	{
		private Vacuum CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (string, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((string, AbsoluteSimulationFrame));
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
