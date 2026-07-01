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
	public class CoherenceSync_4edd6a9a43616b14798b64cafa40875f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684_CommandTarget;

		private CharacterController _4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140_CommandTarget;

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

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075(_4edd6a9a43616b14798b64cafa40875f_dbf48b39e25349189a7bc88ee12c1075 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4(_4edd6a9a43616b14798b64cafa40875f_33923e71dd894497bdac570f229c68b4 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9(_4edd6a9a43616b14798b64cafa40875f_650ecb5dc79a4fceac219ec6953a8ed9 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b(_4edd6a9a43616b14798b64cafa40875f_7f79ee439e6a4bec927df42a3aae7a5b command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1(_4edd6a9a43616b14798b64cafa40875f_233854b9f45346409e6f6bb2fbec33f1 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7(_4edd6a9a43616b14798b64cafa40875f_0ed78b3a9c6a4971861cf73adb3d33a7 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a(_4edd6a9a43616b14798b64cafa40875f_68a8b4ee18354b78bcaa08ab3369560a command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e(_4edd6a9a43616b14798b64cafa40875f_8edc36e7c262493a849d84f3b210ee6e command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2(_4edd6a9a43616b14798b64cafa40875f_e3f79cb24d2f4b3a8d259d33bf78b5c2 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b(_4edd6a9a43616b14798b64cafa40875f_126c4b0b7dfc45b08ded76e87f832d2b command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed(_4edd6a9a43616b14798b64cafa40875f_b3f0c86161964ced8515f7f3c2f812ed command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684(_4edd6a9a43616b14798b64cafa40875f_e4f9ae9c706a4e8d9e3aa41f052e8684 command)
		{
		}

		private void BakeCommandBinding__4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140(_4edd6a9a43616b14798b64cafa40875f_581aab42669a4c629114e23a513d7140 command)
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
