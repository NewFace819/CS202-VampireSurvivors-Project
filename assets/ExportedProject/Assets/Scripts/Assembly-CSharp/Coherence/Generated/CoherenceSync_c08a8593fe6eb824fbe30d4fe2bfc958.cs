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
	public class CoherenceSync_c08a8593fe6eb824fbe30d4fe2bfc958 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea_CommandTarget;

		private CharacterController _c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68_CommandTarget;

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

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e(_c08a8593fe6eb824fbe30d4fe2bfc958_3b4151e024374b0c94f951e8bd7af95e command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124(_c08a8593fe6eb824fbe30d4fe2bfc958_5c3e4fade145499da20d2b19af7a2124 command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa(_c08a8593fe6eb824fbe30d4fe2bfc958_e68318a248cb40d390c8eea16a679faa command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a(_c08a8593fe6eb824fbe30d4fe2bfc958_d7a6a522a3574a809c8374b526c8ec5a command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31(_c08a8593fe6eb824fbe30d4fe2bfc958_53ebd3fda41c491ea7b3e797643d4d31 command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3(_c08a8593fe6eb824fbe30d4fe2bfc958_f714af32940d4bdb934856969c2616a3 command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8(_c08a8593fe6eb824fbe30d4fe2bfc958_efd59bcbae264670b930fe3917fdcac8 command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955(_c08a8593fe6eb824fbe30d4fe2bfc958_2b772099f5a440c2ad6f6e3ab698d955 command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd(_c08a8593fe6eb824fbe30d4fe2bfc958_5a8d0cab7f8a4131ae59802f932be7bd command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed(_c08a8593fe6eb824fbe30d4fe2bfc958_6f2e120bc14b4ae18aae516231d972ed command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b(_c08a8593fe6eb824fbe30d4fe2bfc958_acce40ef538e450db04735d4cdc2e88b command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea(_c08a8593fe6eb824fbe30d4fe2bfc958_fbb37b1daec84123a25e2e43114476ea command)
		{
		}

		private void BakeCommandBinding__c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68(_c08a8593fe6eb824fbe30d4fe2bfc958_9c2f154bf51a4f128160e49e02370c68 command)
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
