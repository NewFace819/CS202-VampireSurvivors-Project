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
	public class CoherenceSync_d85c0fb147488bf4386472624606ae10 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746_CommandTarget;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be_CommandTarget;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8_CommandTarget;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498_CommandTarget;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5_CommandTarget;

		private NetworkPickup _d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7_CommandTarget;

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

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746(_d85c0fb147488bf4386472624606ae10_7659b24151dc4f4fbcb9b8bae77fb746 command)
		{
		}

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be(_d85c0fb147488bf4386472624606ae10_a560fc2f921f457f9157ce42a59ea0be command)
		{
		}

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8(_d85c0fb147488bf4386472624606ae10_b7f94930c9654e61b8b090b2d19045f8 command)
		{
		}

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498(_d85c0fb147488bf4386472624606ae10_0adf9b22b96c4f1fa95a47cb1070e498 command)
		{
		}

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5(_d85c0fb147488bf4386472624606ae10_e0334b4ac7034512aba4b45024e1b2f5 command)
		{
		}

		private void BakeCommandBinding__d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7(_d85c0fb147488bf4386472624606ae10_ed47ebf00e7440c3b56513329f0bbdf7 command)
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
