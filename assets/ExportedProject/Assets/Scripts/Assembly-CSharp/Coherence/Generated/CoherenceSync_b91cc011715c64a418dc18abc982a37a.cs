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
	public class CoherenceSync_b91cc011715c64a418dc18abc982a37a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83_CommandTarget;

		private Enemy_TP_GateBoss _b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5_CommandTarget;

		private Enemy_TP_GateBoss _b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e_CommandTarget;

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

		private void BakeCommandBinding__b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83(_b91cc011715c64a418dc18abc982a37a_01c091811dd74e7abf96f0880496ac83 command)
		{
		}

		private void BakeCommandBinding__b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5(_b91cc011715c64a418dc18abc982a37a_2a60819541404e5faf8a2693cb49f2d5 command)
		{
		}

		private void BakeCommandBinding__b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e(_b91cc011715c64a418dc18abc982a37a_8fb83da5a5454567b1271609cb21e99e command)
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
