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
	public class CoherenceSync_a36f0e13e6d64be4baaf6a40902866f7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e_CommandTarget;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242_CommandTarget;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6_CommandTarget;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f_CommandTarget;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f_CommandTarget;

		private NetworkPickup _a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4_CommandTarget;

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

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e(_a36f0e13e6d64be4baaf6a40902866f7_60bb04d09dee455bbef7106adcc0130e command)
		{
		}

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242(_a36f0e13e6d64be4baaf6a40902866f7_1e38235a48214cbd9307ace355dd9242 command)
		{
		}

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6(_a36f0e13e6d64be4baaf6a40902866f7_6e4f7050d56b4f939078b7d74df61de6 command)
		{
		}

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f(_a36f0e13e6d64be4baaf6a40902866f7_df57ef5290704aee9c9692c1438d6a1f command)
		{
		}

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f(_a36f0e13e6d64be4baaf6a40902866f7_e60754db87fa4223ad66e8397bb7ad2f command)
		{
		}

		private void BakeCommandBinding__a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4(_a36f0e13e6d64be4baaf6a40902866f7_f660ae236a434285af7f7e20d75843b4 command)
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
