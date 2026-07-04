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
	public class CoherenceSync_6ef7c0baad4dee54584188b4e3f62f97 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b_CommandTarget;

		private CharacterController _6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493_CommandTarget;

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

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab(_6ef7c0baad4dee54584188b4e3f62f97_b9bf3e5debe249cb88f025704f0e64ab command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148(_6ef7c0baad4dee54584188b4e3f62f97_4487133649e344528c2ac18f363cc148 command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2(_6ef7c0baad4dee54584188b4e3f62f97_b176ff6ebacb40d08b54b7e884a1c8e2 command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e(_6ef7c0baad4dee54584188b4e3f62f97_3f36dc75deba497f838eb608425bfa3e command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e(_6ef7c0baad4dee54584188b4e3f62f97_32e3d5201da849c0901f110081e0489e command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e(_6ef7c0baad4dee54584188b4e3f62f97_0a553ca14cfc44fe959a57319df5980e command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243(_6ef7c0baad4dee54584188b4e3f62f97_b373ecbfe40c4d18bcc8522652f46243 command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f(_6ef7c0baad4dee54584188b4e3f62f97_66b2f9ad6c644034987a01feea5bea2f command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4(_6ef7c0baad4dee54584188b4e3f62f97_36be8f77cda54a64bff090aa0a818ba4 command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6(_6ef7c0baad4dee54584188b4e3f62f97_5ca587889ace494ba6511c27518397b6 command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b(_6ef7c0baad4dee54584188b4e3f62f97_ad1c07d5d4734448aaba9c774196a12b command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b(_6ef7c0baad4dee54584188b4e3f62f97_7effa6193cc6428c9de08e8157593d2b command)
		{
		}

		private void BakeCommandBinding__6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493(_6ef7c0baad4dee54584188b4e3f62f97_b6474e29fa8d44389255304fa86e5493 command)
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
