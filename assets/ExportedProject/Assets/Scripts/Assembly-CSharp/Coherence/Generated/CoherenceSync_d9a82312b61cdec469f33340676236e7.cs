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
	public class CoherenceSync_d9a82312b61cdec469f33340676236e7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c_CommandTarget;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057_CommandTarget;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55_CommandTarget;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3_CommandTarget;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495_CommandTarget;

		private NetworkPickup _d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166_CommandTarget;

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

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c(_d9a82312b61cdec469f33340676236e7_79e6ebfbbdb94d34a9843f26c692fd9c command)
		{
		}

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057(_d9a82312b61cdec469f33340676236e7_77ff1f95b39e4741bbf9d340cc24c057 command)
		{
		}

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55(_d9a82312b61cdec469f33340676236e7_e3bf4b4b0dbe41e58ee442078f007c55 command)
		{
		}

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3(_d9a82312b61cdec469f33340676236e7_7821b58c042541b790597792fea424d3 command)
		{
		}

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495(_d9a82312b61cdec469f33340676236e7_b90cbb6ce63249ca84a3e80052b64495 command)
		{
		}

		private void BakeCommandBinding__d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166(_d9a82312b61cdec469f33340676236e7_8e42ebd452cb42f981db23cc2fe85166 command)
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
