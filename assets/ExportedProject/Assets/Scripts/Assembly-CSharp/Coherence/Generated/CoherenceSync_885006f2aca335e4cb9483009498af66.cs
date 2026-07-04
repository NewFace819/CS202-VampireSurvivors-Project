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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_885006f2aca335e4cb9483009498af66 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef_CommandTarget;

		private Enemy_TP_GateBoss _885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b_CommandTarget;

		private Enemy_TP_GateBoss _885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8_CommandTarget;

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

		private void BakeCommandBinding__885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef(_885006f2aca335e4cb9483009498af66_f1c5a6e1e45f45e5bfe1d48257a37bef command)
		{
		}

		private void BakeCommandBinding__885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b(_885006f2aca335e4cb9483009498af66_5972f2507e274b4296e036c1194eb65b command)
		{
		}

		private void BakeCommandBinding__885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8(_885006f2aca335e4cb9483009498af66_2eef676fc9d542e384346af034d60cb8 command)
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
