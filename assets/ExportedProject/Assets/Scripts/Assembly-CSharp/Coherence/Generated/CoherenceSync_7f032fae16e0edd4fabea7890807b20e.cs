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
	public class CoherenceSync_7f032fae16e0edd4fabea7890807b20e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33_CommandTarget;

		private Enemy_TP_GateBoss _7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d_CommandTarget;

		private Enemy_TP_GateBoss _7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a_CommandTarget;

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

		private void BakeCommandBinding__7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33(_7f032fae16e0edd4fabea7890807b20e_9ff6199e97a4467488fea5eb49b89d33 command)
		{
		}

		private void BakeCommandBinding__7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d(_7f032fae16e0edd4fabea7890807b20e_e48d4c6df2d34c26a54abede3f16ac1d command)
		{
		}

		private void BakeCommandBinding__7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a(_7f032fae16e0edd4fabea7890807b20e_9e760065e8c74a8bac52e41ce382928a command)
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
