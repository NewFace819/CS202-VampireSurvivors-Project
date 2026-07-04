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
	public class CoherenceSync_0dea4d311a8ad4f47a1ed47e23e15854 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6_CommandTarget;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168_CommandTarget;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84_CommandTarget;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998_CommandTarget;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3_CommandTarget;

		private NetworkPickup _0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621_CommandTarget;

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

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6(_0dea4d311a8ad4f47a1ed47e23e15854_de1a6b642d984f40aee45bc353808ae6 command)
		{
		}

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168(_0dea4d311a8ad4f47a1ed47e23e15854_64c078aa403142a3afe2488d510b5168 command)
		{
		}

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84(_0dea4d311a8ad4f47a1ed47e23e15854_2fbce04a0d9f4c6b88fd642e0eff7a84 command)
		{
		}

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998(_0dea4d311a8ad4f47a1ed47e23e15854_1f12f143d189482d918596459e607998 command)
		{
		}

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3(_0dea4d311a8ad4f47a1ed47e23e15854_41043fcebba14f2b94eebc8f0b8a7ea3 command)
		{
		}

		private void BakeCommandBinding__0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621(_0dea4d311a8ad4f47a1ed47e23e15854_730baf931b434c0d92bc658a0221d621 command)
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
