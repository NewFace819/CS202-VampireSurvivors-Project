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
	public class CoherenceSync_6f907e4de406af4469f4f94755ec0b51 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb_CommandTarget;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0_CommandTarget;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e_CommandTarget;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107_CommandTarget;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871_CommandTarget;

		private NetworkPickup _6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53_CommandTarget;

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

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb(_6f907e4de406af4469f4f94755ec0b51_ebcb3fe08c764eaba0ade032a50395fb command)
		{
		}

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0(_6f907e4de406af4469f4f94755ec0b51_f0df0aa2af814b889fae7838c4fd8ca0 command)
		{
		}

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e(_6f907e4de406af4469f4f94755ec0b51_77604428376445e8a6b5552da3016b4e command)
		{
		}

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107(_6f907e4de406af4469f4f94755ec0b51_d95800713ec4469bb193b6b9f096c107 command)
		{
		}

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871(_6f907e4de406af4469f4f94755ec0b51_1ef40833ede34a179f4a2684a0c2b871 command)
		{
		}

		private void BakeCommandBinding__6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53(_6f907e4de406af4469f4f94755ec0b51_27ba9ad3adef4102936a9849b3addb53 command)
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
