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
	public class CoherenceSync_165b658cae906d24a91ab737f3b7d077 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5_CommandTarget;

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

		private void BakeCommandBinding__165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5(_165b658cae906d24a91ab737f3b7d077_5d01474015974901871dcaef35f638d5 command)
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
