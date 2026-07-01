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
	public class CoherenceSync_88b68dbaed804624b8f27ed0be24b05d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6_CommandTarget;

		private CharacterController _88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff_CommandTarget;

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

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549(_88b68dbaed804624b8f27ed0be24b05d_3297010767ba4101b7addb5961781549 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd(_88b68dbaed804624b8f27ed0be24b05d_46681056b5e1494cb1971f900a384ccd command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049(_88b68dbaed804624b8f27ed0be24b05d_7a6be6b206c343d1872d56bf28f4d049 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9(_88b68dbaed804624b8f27ed0be24b05d_5ad70a1936fe44ba9fe7c55494f530c9 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88(_88b68dbaed804624b8f27ed0be24b05d_314c77bf27b8408d8bbadb3b3f6f1b88 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682(_88b68dbaed804624b8f27ed0be24b05d_effbc6bc1ef54df98e44cc3652031682 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee(_88b68dbaed804624b8f27ed0be24b05d_1463f202df03445d9bad892764e312ee command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb(_88b68dbaed804624b8f27ed0be24b05d_6f50919f45ab4e2dac35719dff272fdb command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05(_88b68dbaed804624b8f27ed0be24b05d_655d78d7f42c4883844b3bd2c17afd05 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c(_88b68dbaed804624b8f27ed0be24b05d_e695eeda2af04d40a3d85cc615e39f2c command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b(_88b68dbaed804624b8f27ed0be24b05d_f08046a38f30403a89520ada6256875b command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6(_88b68dbaed804624b8f27ed0be24b05d_b8b8a6554c1144fe90ffd3658ab2dfe6 command)
		{
		}

		private void BakeCommandBinding__88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff(_88b68dbaed804624b8f27ed0be24b05d_e4eeb8a5c1a4414895e88af11001b4ff command)
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
