using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_f14a7ff0761a1f741827d543c2089a5e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc_CommandTarget;

		private IClient client;

		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings;

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings;

		public override Binding BakeValueBinding(Binding valueBinding)
		{
			return null;
		}

		public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void BakeCommandBinding__f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc(_f14a7ff0761a1f741827d543c2089a5e_c07d23426a6b4babb363775dce7c13bc command)
		{
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
		}

		public override void CreateEntity(bool usesLodsAtRuntime, string archetypeName, AbsoluteSimulationFrame simFrame, List<ICoherenceComponentData> components)
		{
		}

		public override void Dispose()
		{
		}

		public override void Initialize(Entity entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
		{
		}
	}
}
