using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_9e940c09a19335f4cb9779bb7911503e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797_CommandTarget;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239_CommandTarget;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a_CommandTarget;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327_CommandTarget;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573_CommandTarget;

		private NetworkPickup _9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1_CommandTarget;

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

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797(_9e940c09a19335f4cb9779bb7911503e_347a5be6d53a4e1b86bfa6c676aae797 command)
		{
		}

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239(_9e940c09a19335f4cb9779bb7911503e_47138e32adc045ab85e76f49b63eb239 command)
		{
		}

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a(_9e940c09a19335f4cb9779bb7911503e_476dc86044964e75843d6e8738a6221a command)
		{
		}

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327(_9e940c09a19335f4cb9779bb7911503e_7676f0c764d84b58994e123a7c218327 command)
		{
		}

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573(_9e940c09a19335f4cb9779bb7911503e_09a0015d1ea54a27bdc68e62a7f87573 command)
		{
		}

		private void BakeCommandBinding__9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1(_9e940c09a19335f4cb9779bb7911503e_64fe7b9579d34ed4b3175148120c52f1 command)
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
