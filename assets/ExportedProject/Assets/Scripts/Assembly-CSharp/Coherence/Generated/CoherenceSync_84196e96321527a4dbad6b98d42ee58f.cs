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
	public class CoherenceSync_84196e96321527a4dbad6b98d42ee58f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c_CommandTarget;

		private EnemyTaka _84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62_CommandTarget;

		private EnemyTaka _84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a_CommandTarget;

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

		private void BakeCommandBinding__84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c(_84196e96321527a4dbad6b98d42ee58f_c9b14b15d7144f8cb321b0f71f35ff6c command)
		{
		}

		private void BakeCommandBinding__84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62(_84196e96321527a4dbad6b98d42ee58f_23f0b6a6a8fc4a919e4d37faeb054a62 command)
		{
		}

		private void BakeCommandBinding__84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a(_84196e96321527a4dbad6b98d42ee58f_62cf3ce35e33447c984ee7ad827de94a command)
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
