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
	public class CoherenceSync_d4f305a2aee3ecd449a3412d3f0c9ad9 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88_CommandTarget;

		private CharacterController _d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8_CommandTarget;

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

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639(_d4f305a2aee3ecd449a3412d3f0c9ad9_02d556be3f24429287a1a3df6fd32639 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8(_d4f305a2aee3ecd449a3412d3f0c9ad9_3a90d0f9e5d045f4a45f8f3f9b661ea8 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8(_d4f305a2aee3ecd449a3412d3f0c9ad9_bfe795439d484bd28a4259085c8773d8 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246(_d4f305a2aee3ecd449a3412d3f0c9ad9_0961804624514f739aca20466dcc0246 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2(_d4f305a2aee3ecd449a3412d3f0c9ad9_aececa08a00f4f9c8e5fb8ba247610a2 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db(_d4f305a2aee3ecd449a3412d3f0c9ad9_fe6b6b65a9e74e968cde1cbca77e82db command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3(_d4f305a2aee3ecd449a3412d3f0c9ad9_6ac70d8cb4e94120a93db260c85259e3 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f(_d4f305a2aee3ecd449a3412d3f0c9ad9_e1568aa352a84bdb937265494038b82f command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843(_d4f305a2aee3ecd449a3412d3f0c9ad9_8f74a650ba6341a48fdd4e0e3b44b843 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884(_d4f305a2aee3ecd449a3412d3f0c9ad9_62ac768e871e452b9ce14a72f3439884 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a(_d4f305a2aee3ecd449a3412d3f0c9ad9_1c71ef2679ee42f68dcb6a2bc2d1166a command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88(_d4f305a2aee3ecd449a3412d3f0c9ad9_11e1881ac47342368c1ed0c9b521fc88 command)
		{
		}

		private void BakeCommandBinding__d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8(_d4f305a2aee3ecd449a3412d3f0c9ad9_2af25da7688f4665b8893b13f3d817f8 command)
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
