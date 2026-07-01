using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_90bad6f3af15ab342805cd8a335ea1d0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81_CommandTarget;

		private CharacterController _90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f_CommandTarget;

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

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b(_90bad6f3af15ab342805cd8a335ea1d0_a7cc2dc047c842e7987d183694ae832b command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c(_90bad6f3af15ab342805cd8a335ea1d0_ca890b7860834d6ca548ab541f0d5c5c command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9(_90bad6f3af15ab342805cd8a335ea1d0_be537c7e549d4ab199370882a420c3e9 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2(_90bad6f3af15ab342805cd8a335ea1d0_058c33096dd54a2b8334d98c3cb6b2b2 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79(_90bad6f3af15ab342805cd8a335ea1d0_689f62bc5b7a4762a00ef1d620f0db79 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2(_90bad6f3af15ab342805cd8a335ea1d0_b2f2312476ed4fd694aa533c05e13dd2 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c(_90bad6f3af15ab342805cd8a335ea1d0_4bd9dbff6c2b4fc0bf13687906adb39c command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac(_90bad6f3af15ab342805cd8a335ea1d0_83a8228e2a2f44ee8a3d2cb9d5e4c8ac command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1(_90bad6f3af15ab342805cd8a335ea1d0_179c9c79afa1404eb759f726056fe5a1 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc(_90bad6f3af15ab342805cd8a335ea1d0_e5d12fcfc1924690b9ba1d3d4d1915bc command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2(_90bad6f3af15ab342805cd8a335ea1d0_18892294330c46b5bf29021631080fb2 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81(_90bad6f3af15ab342805cd8a335ea1d0_a9fe799e3d5144fbb05efe2a34788f81 command)
		{
		}

		private void BakeCommandBinding__90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f(_90bad6f3af15ab342805cd8a335ea1d0_a0dea1a29de04ab198f6169077c9130f command)
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
