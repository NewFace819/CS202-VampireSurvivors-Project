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
	public class CoherenceSync_63e87ccaf095e7e45adea95a26e4af50 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388_CommandTarget;

		private TP_Walter_Character _63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a_CommandTarget;

		private CharacterController _63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b_CommandTarget;

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

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6(_63e87ccaf095e7e45adea95a26e4af50_9f9d2e7f16984119aa76c5c25f3615c6 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056(_63e87ccaf095e7e45adea95a26e4af50_731754f94b0f462f9a9761e418f8a056 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330(_63e87ccaf095e7e45adea95a26e4af50_aa9c48d217954792a2fe01702244a330 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98(_63e87ccaf095e7e45adea95a26e4af50_ba9def6b6fa4409f94113566f0991f98 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0(_63e87ccaf095e7e45adea95a26e4af50_64f13e7881d04dfdb2cf4d9e77e75ad0 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4(_63e87ccaf095e7e45adea95a26e4af50_564b0059c05b4e0697c68321cec785c4 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef(_63e87ccaf095e7e45adea95a26e4af50_b436a66727074086a265541c54304eef command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516(_63e87ccaf095e7e45adea95a26e4af50_ab6a9a0b4ab34c8aa7cc825378f3e516 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825(_63e87ccaf095e7e45adea95a26e4af50_5363df79fe7f4aeaa8d4cb8501b58825 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388(_63e87ccaf095e7e45adea95a26e4af50_208176f7cc5d466e87edb986c174b388 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3(_63e87ccaf095e7e45adea95a26e4af50_e769c40011a047d8aaaa3fd1d2dbcba3 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853(_63e87ccaf095e7e45adea95a26e4af50_f8947e849ce54bbfab516678b0cd3853 command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a(_63e87ccaf095e7e45adea95a26e4af50_80a8ba2cb5e846e6a216a909c53b817a command)
		{
		}

		private void BakeCommandBinding__63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b(_63e87ccaf095e7e45adea95a26e4af50_2dc0651f9e344984b83fc704039bc96b command)
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
