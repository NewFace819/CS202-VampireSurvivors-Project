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
	public class CoherenceSync_83c417cc5141cce45af977f02ac9c335 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d_CommandTarget;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b_CommandTarget;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24_CommandTarget;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57_CommandTarget;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a_CommandTarget;

		private NetworkPickup _83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d_CommandTarget;

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

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d(_83c417cc5141cce45af977f02ac9c335_590081ef9ce74b39b9c88e9ebfa2577d command)
		{
		}

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b(_83c417cc5141cce45af977f02ac9c335_7056110de0d444a2beca7ce9dc5b6b0b command)
		{
		}

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24(_83c417cc5141cce45af977f02ac9c335_fd57e22ec18346eca67b6c5070661c24 command)
		{
		}

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57(_83c417cc5141cce45af977f02ac9c335_45a4215cd159499eb72bf87063c7db57 command)
		{
		}

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a(_83c417cc5141cce45af977f02ac9c335_1622bdda88a54fafb0c4a9885635074a command)
		{
		}

		private void BakeCommandBinding__83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d(_83c417cc5141cce45af977f02ac9c335_bbdd7d7f15ad4c7d811cf143b1b1a90d command)
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
