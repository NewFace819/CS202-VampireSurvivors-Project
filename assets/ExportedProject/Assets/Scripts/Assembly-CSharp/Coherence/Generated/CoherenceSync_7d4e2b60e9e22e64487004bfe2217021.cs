using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Props;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_7d4e2b60e9e22e64487004bfe2217021 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private PropFoscariSeal2 _7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2_CommandTarget;

		private Destructible _7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6_CommandTarget;

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

		private void BakeCommandBinding__7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2(_7d4e2b60e9e22e64487004bfe2217021_ce34d9eaa6cf43168956a0db2342cbc2 command)
		{
		}

		private void BakeCommandBinding__7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6(_7d4e2b60e9e22e64487004bfe2217021_ae4feb6399b649f8a73ad0cc3eb8f9d6 command)
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
