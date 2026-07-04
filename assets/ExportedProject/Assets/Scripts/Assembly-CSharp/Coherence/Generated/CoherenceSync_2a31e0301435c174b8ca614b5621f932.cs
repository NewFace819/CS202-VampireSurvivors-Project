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
	public class CoherenceSync_2a31e0301435c174b8ca614b5621f932 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c_CommandTarget;

		private Enemy_TP_GateBoss _2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be_CommandTarget;

		private Enemy_TP_GateBoss _2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956_CommandTarget;

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

		private void BakeCommandBinding__2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c(_2a31e0301435c174b8ca614b5621f932_13578124d9c7481e952cfe7124a3762c command)
		{
		}

		private void BakeCommandBinding__2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be(_2a31e0301435c174b8ca614b5621f932_9af7c39609594eeba04b51c38d0889be command)
		{
		}

		private void BakeCommandBinding__2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956(_2a31e0301435c174b8ca614b5621f932_8ec3c9da4ccc4723be64340e1b06a956 command)
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
