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
	public class CoherenceSync_de4c84c689767f946af1a41e8c5fd592 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46_CommandTarget;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5_CommandTarget;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100_CommandTarget;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66_CommandTarget;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657_CommandTarget;

		private NetworkPickup _de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363_CommandTarget;

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

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46(_de4c84c689767f946af1a41e8c5fd592_c7b2c9d777cf474abe67fe30fb1e7a46 command)
		{
		}

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5(_de4c84c689767f946af1a41e8c5fd592_e23e489051aa4fb9aa33c044823875b5 command)
		{
		}

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100(_de4c84c689767f946af1a41e8c5fd592_1044367f323f42e7934a338ed2be4100 command)
		{
		}

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66(_de4c84c689767f946af1a41e8c5fd592_2fbb2475d1c64b6db09a721097500e66 command)
		{
		}

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657(_de4c84c689767f946af1a41e8c5fd592_2d9b351c5a3844cb87c7f24f4d348657 command)
		{
		}

		private void BakeCommandBinding__de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363(_de4c84c689767f946af1a41e8c5fd592_0e9dead979f34ad7887bd080d5d5c363 command)
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
