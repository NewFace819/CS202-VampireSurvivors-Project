using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_fa7f0442be1b2a04f8e30d669dcc950f_c54b2865ccfe4f319a3a7b4af3801c4d : BoolBinding
	{
		private EX_Boss_Colossus CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override bool Value
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (bool, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((bool, AbsoluteSimulationFrame));
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
