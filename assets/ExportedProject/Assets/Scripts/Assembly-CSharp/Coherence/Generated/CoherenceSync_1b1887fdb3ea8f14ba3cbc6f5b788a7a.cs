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
	public class CoherenceSync_1b1887fdb3ea8f14ba3cbc6f5b788a7a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527_CommandTarget;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8_CommandTarget;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b_CommandTarget;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f_CommandTarget;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810_CommandTarget;

		private NetworkPickup _1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677_CommandTarget;

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

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_631ac90597e5441b883bbbaf823ab527 command)
		{
		}

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_7f0697ea8536474691d9b6d4b29514c8 command)
		{
		}

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_e22e827da1c84e89bf5449b71ffeab2b command)
		{
		}

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_b42255ee878f4b02882d4fafc10b480f command)
		{
		}

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_dbb156699e914d349ea47687485f8810 command)
		{
		}

		private void BakeCommandBinding__1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677(_1b1887fdb3ea8f14ba3cbc6f5b788a7a_25a0db41752d47a49dd681462e627677 command)
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
