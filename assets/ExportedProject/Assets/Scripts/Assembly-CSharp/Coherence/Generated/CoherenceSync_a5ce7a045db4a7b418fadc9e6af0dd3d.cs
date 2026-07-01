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
	public class CoherenceSync_a5ce7a045db4a7b418fadc9e6af0dd3d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59_CommandTarget;

		private TP_Wind_Character _a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea_CommandTarget;

		private CharacterController _a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b_CommandTarget;

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

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0(_a5ce7a045db4a7b418fadc9e6af0dd3d_7e322fb7e3f54b2c83d261450ae03ff0 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6(_a5ce7a045db4a7b418fadc9e6af0dd3d_44e055a652f448a0b8babff85d1cc4d6 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933(_a5ce7a045db4a7b418fadc9e6af0dd3d_dbcb9570ec374772b77cf975c45dd933 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273(_a5ce7a045db4a7b418fadc9e6af0dd3d_97a653958af549168a27faed06abf273 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190(_a5ce7a045db4a7b418fadc9e6af0dd3d_a53a6ed5a0984b22b061af1feb2ea190 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8(_a5ce7a045db4a7b418fadc9e6af0dd3d_1abeadfe88a643d8903c2f83701b55a8 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85(_a5ce7a045db4a7b418fadc9e6af0dd3d_3e9b88a04e2147a0876490dab168ab85 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86(_a5ce7a045db4a7b418fadc9e6af0dd3d_5bafb05ea697493c90a1447768c66b86 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5(_a5ce7a045db4a7b418fadc9e6af0dd3d_fb84571090e647bc9c37c68259a521d5 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59(_a5ce7a045db4a7b418fadc9e6af0dd3d_9b385b21920f4eac9046699f3f7e9e59 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863(_a5ce7a045db4a7b418fadc9e6af0dd3d_8b62b6bf21c5450b90c55993d6aad863 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0(_a5ce7a045db4a7b418fadc9e6af0dd3d_8530390074bf4c888bee3f6688d993b0 command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea(_a5ce7a045db4a7b418fadc9e6af0dd3d_8effbe7fcf79448d99d1f6d587e071ea command)
		{
		}

		private void BakeCommandBinding__a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b(_a5ce7a045db4a7b418fadc9e6af0dd3d_9b14f383b108447fab1768f600594d8b command)
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
