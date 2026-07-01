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
	public class CoherenceSync_4c5721e499679dc499cc55be525ab38a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e_CommandTarget;

		private CharacterController _4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445_CommandTarget;

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

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322(_4c5721e499679dc499cc55be525ab38a_11e15c7d0222474789787ca994621322 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2(_4c5721e499679dc499cc55be525ab38a_c6f7ed09ff3e4797ac078cac669bf6f2 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b(_4c5721e499679dc499cc55be525ab38a_3afa45f023864fdcba7b9841fb30444b command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30(_4c5721e499679dc499cc55be525ab38a_cffb0d832f0a4ad5a608c644a3de3f30 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7(_4c5721e499679dc499cc55be525ab38a_963dc7109b3041b0886b36771cec20e7 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4(_4c5721e499679dc499cc55be525ab38a_04aef0157d874f82ad344455effc19d4 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d(_4c5721e499679dc499cc55be525ab38a_e1b73c2018264bf1b34172a4ca90188d command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec(_4c5721e499679dc499cc55be525ab38a_92e3a41cd96b4185a7c3cf2f18a5e8ec command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72(_4c5721e499679dc499cc55be525ab38a_94f724722ca14b4f99b1f99e40bc2c72 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124(_4c5721e499679dc499cc55be525ab38a_7f34046719614c629bc7c64baa155124 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4(_4c5721e499679dc499cc55be525ab38a_744477ded12a49768a025b17050021a4 command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e(_4c5721e499679dc499cc55be525ab38a_ad64dc5415f640e680b75a230db85a4e command)
		{
		}

		private void BakeCommandBinding__4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445(_4c5721e499679dc499cc55be525ab38a_e6f810b70703423380048e406c10d445 command)
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
