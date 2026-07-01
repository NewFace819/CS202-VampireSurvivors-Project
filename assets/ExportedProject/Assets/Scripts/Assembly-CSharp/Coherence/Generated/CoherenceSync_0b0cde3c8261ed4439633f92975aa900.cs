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
	public class CoherenceSync_0b0cde3c8261ed4439633f92975aa900 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0_CommandTarget;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519_CommandTarget;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a_CommandTarget;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c_CommandTarget;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4_CommandTarget;

		private NetworkPickup _0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121_CommandTarget;

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

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0(_0b0cde3c8261ed4439633f92975aa900_c6381c251c964621bc8878f2a0b716a0 command)
		{
		}

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519(_0b0cde3c8261ed4439633f92975aa900_85a917dbc9c04d3ab295da29c282c519 command)
		{
		}

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a(_0b0cde3c8261ed4439633f92975aa900_82614c6ddb5647feada4698a6ae2891a command)
		{
		}

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c(_0b0cde3c8261ed4439633f92975aa900_d1266c5b208d49ffafb9145f5d5d9b2c command)
		{
		}

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4(_0b0cde3c8261ed4439633f92975aa900_e8bc4a74950744908cb5bd0be2850bf4 command)
		{
		}

		private void BakeCommandBinding__0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121(_0b0cde3c8261ed4439633f92975aa900_e15c28b4529147329baa5feaeae85121 command)
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
