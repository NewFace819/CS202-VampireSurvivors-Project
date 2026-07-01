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
	public class CoherenceSync_eea9fb6fd47bf0347bef7c5689647770 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed_CommandTarget;

		private CharacterController _eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3_CommandTarget;

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

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0(_eea9fb6fd47bf0347bef7c5689647770_ec11ea06fbd24f62bf053e4e843039b0 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8(_eea9fb6fd47bf0347bef7c5689647770_f2ca2883d6724a40ab860015ba7b2ca8 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689(_eea9fb6fd47bf0347bef7c5689647770_9847712ae42b40599cec31f3d0c73689 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23(_eea9fb6fd47bf0347bef7c5689647770_4bca0fa93c1b4b27b8dc647d53517f23 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276(_eea9fb6fd47bf0347bef7c5689647770_7051ba6e0d60489cb57fc8dbceb18276 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047(_eea9fb6fd47bf0347bef7c5689647770_b722c784ccce4528882ebd4a521d1047 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c(_eea9fb6fd47bf0347bef7c5689647770_2018c07155bd49bb8461190ffd3df56c command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f(_eea9fb6fd47bf0347bef7c5689647770_86e1faa047fd4f368e304ccd8caff67f command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd(_eea9fb6fd47bf0347bef7c5689647770_fd8955504fae495b99fe55a057cd65fd command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c(_eea9fb6fd47bf0347bef7c5689647770_aa01c89d726b474eac2505ae3cad816c command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6(_eea9fb6fd47bf0347bef7c5689647770_5da15c313a45428cacf4602425df52e6 command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed(_eea9fb6fd47bf0347bef7c5689647770_918b9ea3877044daa3ad849226812aed command)
		{
		}

		private void BakeCommandBinding__eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3(_eea9fb6fd47bf0347bef7c5689647770_c2cc620b97bd4cfe9517d779201e4aa3 command)
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
