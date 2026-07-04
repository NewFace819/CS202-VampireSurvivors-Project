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
	public class CoherenceSync_220d0e54abafe5c4e98eb765d5d2aabd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe_CommandTarget;

		private EnemyLegionSection _220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938_CommandTarget;

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

		private void BakeCommandBinding__220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe(_220d0e54abafe5c4e98eb765d5d2aabd_049c617581084772bd319d81661ab1fe command)
		{
		}

		private void BakeCommandBinding__220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938(_220d0e54abafe5c4e98eb765d5d2aabd_5a81b0e1d6c64828a71faaf627062938 command)
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
