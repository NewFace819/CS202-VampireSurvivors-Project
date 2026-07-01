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
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_9554c42f3c82c79478c055749f76ba4c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Pickup_EME_Cat _9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e_CommandTarget;

		private NetworkPickup _9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d_CommandTarget;

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

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969(_9554c42f3c82c79478c055749f76ba4c_1f0dbbc3472b4cb1a47ec2265a805969 command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a(_9554c42f3c82c79478c055749f76ba4c_3499cc3fe6e54d1f9f8c4d7d255b773a command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576(_9554c42f3c82c79478c055749f76ba4c_9b2b50be795f41258421b235a5830576 command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276(_9554c42f3c82c79478c055749f76ba4c_6c190c395d524de69353a57c273af276 command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba(_9554c42f3c82c79478c055749f76ba4c_b0daa20f421b4491b6a4bb342ec936ba command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e(_9554c42f3c82c79478c055749f76ba4c_76432ba32e6e4e36982c0d3e4f2e9a4e command)
		{
		}

		private void BakeCommandBinding__9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d(_9554c42f3c82c79478c055749f76ba4c_462a225817f94d0eb6f6d16858704a3d command)
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
