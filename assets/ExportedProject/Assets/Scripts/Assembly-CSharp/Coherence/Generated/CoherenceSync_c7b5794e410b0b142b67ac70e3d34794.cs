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
	public class CoherenceSync_c7b5794e410b0b142b67ac70e3d34794 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5_CommandTarget;

		private CharacterController _c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f_CommandTarget;

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

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4(_c7b5794e410b0b142b67ac70e3d34794_74235387bca144568c03bad1b549e1f4 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a(_c7b5794e410b0b142b67ac70e3d34794_c0834b91de8e4ef3aa368cacfb8a9f0a command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821(_c7b5794e410b0b142b67ac70e3d34794_d2973f7dbc124a4fbbffb81b17892821 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5(_c7b5794e410b0b142b67ac70e3d34794_b56ee6aa0d96412c830a34ec9bf702a5 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5(_c7b5794e410b0b142b67ac70e3d34794_efa7abd0f3d84cd28e64ba0a06e519d5 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c(_c7b5794e410b0b142b67ac70e3d34794_50b671ead65041bf813d19483bcc156c command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370(_c7b5794e410b0b142b67ac70e3d34794_16aa9f4c20bb48b4aa4a5211edca3370 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3(_c7b5794e410b0b142b67ac70e3d34794_cf9c69cca0e74cdba212855d597d82a3 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5(_c7b5794e410b0b142b67ac70e3d34794_56583f27524e4267ba0b920b32c36ee5 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033(_c7b5794e410b0b142b67ac70e3d34794_38e7ec1db55d4b779238018642299033 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468(_c7b5794e410b0b142b67ac70e3d34794_9da509f5431c42c99b03aadf8ffa5468 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5(_c7b5794e410b0b142b67ac70e3d34794_6fc8fba7995b42079437a547f3d9bec5 command)
		{
		}

		private void BakeCommandBinding__c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f(_c7b5794e410b0b142b67ac70e3d34794_f9c595f0da0a421daecd4e568ba6133f command)
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
