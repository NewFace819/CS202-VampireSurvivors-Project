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
	public class CoherenceSync_dce3c45c77e3fa5448190d013d3553a9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d_CommandTarget;

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

		private void BakeCommandBinding__dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d(_dce3c45c77e3fa5448190d013d3553a9_4b0a8bf61c43482d9d4be2b65c9ae18d command)
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
