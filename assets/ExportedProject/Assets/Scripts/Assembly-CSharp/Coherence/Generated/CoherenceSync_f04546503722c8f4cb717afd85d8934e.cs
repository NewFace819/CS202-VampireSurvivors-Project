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
	public class CoherenceSync_f04546503722c8f4cb717afd85d8934e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d_CommandTarget;

		private HostPlayerOptions _f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9_CommandTarget;

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

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432(_f04546503722c8f4cb717afd85d8934e_e5c8efdd89b4403dbf4659417dc12432 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8(_f04546503722c8f4cb717afd85d8934e_db0f9943a82a4d31bcf877cbc496a4b8 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1(_f04546503722c8f4cb717afd85d8934e_d8cadcfda8b84593a8427287ff654ed1 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d(_f04546503722c8f4cb717afd85d8934e_cc9b38b79e234b6c856c077287345c0d command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d(_f04546503722c8f4cb717afd85d8934e_1f02c153b96b4f7b9d8e0029a5f5237d command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002(_f04546503722c8f4cb717afd85d8934e_416bdbb41fa34bb58e742b5347690002 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a(_f04546503722c8f4cb717afd85d8934e_c2f577788d994a5e9864772a3449a34a command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289(_f04546503722c8f4cb717afd85d8934e_58f5787948444c0ab2ebb3891a35d289 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378(_f04546503722c8f4cb717afd85d8934e_f2cf6d3584bf40b3be129aee37c90378 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032(_f04546503722c8f4cb717afd85d8934e_1333c9a519fb4328a1c9fb9f89ebf032 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d(_f04546503722c8f4cb717afd85d8934e_2aaa017fb38f4004864c41f464a2622d command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e(_f04546503722c8f4cb717afd85d8934e_370e799c226a461489f978c1ea35aa9e command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909(_f04546503722c8f4cb717afd85d8934e_a5efb630bd29418aa4173a62d2672909 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369(_f04546503722c8f4cb717afd85d8934e_4098aca73afa4076a44d9a9edc8c6369 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218(_f04546503722c8f4cb717afd85d8934e_0c259dec7d5a4e0986e662c822d5b218 command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d(_f04546503722c8f4cb717afd85d8934e_6deedf88810b4dd09d21cce2536cf47d command)
		{
		}

		private void BakeCommandBinding__f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9(_f04546503722c8f4cb717afd85d8934e_55d1644f6b584a67bb371e1eaee370a9 command)
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
