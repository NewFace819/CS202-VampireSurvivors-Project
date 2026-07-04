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
	public class CoherenceSync_25a206885df49204c80489434d96d743 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293_CommandTarget;

		private CharacterController _25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473_CommandTarget;

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

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad(_25a206885df49204c80489434d96d743_9898b882f6ef463eb1580666f6268dad command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab(_25a206885df49204c80489434d96d743_2ee28f0739334d058bc265793314e5ab command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd(_25a206885df49204c80489434d96d743_7bef9833ad634d5c8558d8d7ceacddbd command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2(_25a206885df49204c80489434d96d743_de632f05f4314b32aa2d6da6bff2adc2 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349(_25a206885df49204c80489434d96d743_8777b87cb17445e5b082f8e611ebc349 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978(_25a206885df49204c80489434d96d743_309b67ea25ed4112b2de6c2db86f7978 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219(_25a206885df49204c80489434d96d743_83d0eb7bf099428896176f4bd5f77219 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0(_25a206885df49204c80489434d96d743_9cb7ed8ac9724b8d95222bdc903b0ec0 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749(_25a206885df49204c80489434d96d743_1844f536c4df484abd58bc59d7b52749 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2(_25a206885df49204c80489434d96d743_4885719a8ee8410cb6d56be751bae1c2 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb(_25a206885df49204c80489434d96d743_d8e7112225e2486eae5d751bc46d19eb command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293(_25a206885df49204c80489434d96d743_704bd3f2c0a7456999014ec4e34c5293 command)
		{
		}

		private void BakeCommandBinding__25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473(_25a206885df49204c80489434d96d743_7371d17455844020b3f98287c2299473 command)
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
