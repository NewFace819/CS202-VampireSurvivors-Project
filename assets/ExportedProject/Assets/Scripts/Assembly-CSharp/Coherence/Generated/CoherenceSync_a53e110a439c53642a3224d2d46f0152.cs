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
	public class CoherenceSync_a53e110a439c53642a3224d2d46f0152 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb_CommandTarget;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428_CommandTarget;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5_CommandTarget;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705_CommandTarget;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87_CommandTarget;

		private NetworkPickup _a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d_CommandTarget;

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

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb(_a53e110a439c53642a3224d2d46f0152_b5a9c0bdf635423daf9586e1f1079efb command)
		{
		}

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428(_a53e110a439c53642a3224d2d46f0152_06b4207e47f34fffa1469bbe07256428 command)
		{
		}

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5(_a53e110a439c53642a3224d2d46f0152_14d803dacd664f14a2591a68adcc85e5 command)
		{
		}

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705(_a53e110a439c53642a3224d2d46f0152_018c994e909e41db8e35609e01cde705 command)
		{
		}

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87(_a53e110a439c53642a3224d2d46f0152_c6ece6f416e54f169fc1c55f097e1d87 command)
		{
		}

		private void BakeCommandBinding__a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d(_a53e110a439c53642a3224d2d46f0152_1972318136d342a99ccedd99f52e098d command)
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
