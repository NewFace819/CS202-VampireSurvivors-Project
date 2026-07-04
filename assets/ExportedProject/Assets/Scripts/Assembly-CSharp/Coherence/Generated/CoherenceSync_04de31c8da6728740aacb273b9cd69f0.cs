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
	public class CoherenceSync_04de31c8da6728740aacb273b9cd69f0 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa_CommandTarget;

		private CharacterController _04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25_CommandTarget;

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

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44(_04de31c8da6728740aacb273b9cd69f0_cddabeb317f5433a838dbd9213afac44 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129(_04de31c8da6728740aacb273b9cd69f0_e4a00de536e4450bb06ce6959ae95129 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084(_04de31c8da6728740aacb273b9cd69f0_e809c3b299a74e2f99a3726d57201084 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e(_04de31c8da6728740aacb273b9cd69f0_fcb717636b514a6a8da062a3b3216c4e command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2(_04de31c8da6728740aacb273b9cd69f0_2d3d6b38418c4dc882075a7384067cb2 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae(_04de31c8da6728740aacb273b9cd69f0_2aaa0980f57543dbb0797ed1573c5dae command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6(_04de31c8da6728740aacb273b9cd69f0_e64a3d59d40f43719b9dac07491bd5b6 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42(_04de31c8da6728740aacb273b9cd69f0_5e0517dc95d34be19ddaa0cff5698a42 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174(_04de31c8da6728740aacb273b9cd69f0_08af708bf8bf4531ade572b95fe8c174 command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f(_04de31c8da6728740aacb273b9cd69f0_bf97e8c31fec4d7aa93472e22f47f46f command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba(_04de31c8da6728740aacb273b9cd69f0_ea1ee467bd6e42afb1435938485273ba command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa(_04de31c8da6728740aacb273b9cd69f0_69dd44cf1bfa4b8590acede2ca6fb7aa command)
		{
		}

		private void BakeCommandBinding__04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25(_04de31c8da6728740aacb273b9cd69f0_2b532766477945948a897140cccc6c25 command)
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
