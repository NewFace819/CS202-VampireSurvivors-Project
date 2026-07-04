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
	public class CoherenceSync_c9a9d977fdad5454babc00ddaab63396 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306_CommandTarget;

		private CharacterController _c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b_CommandTarget;

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

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52(_c9a9d977fdad5454babc00ddaab63396_601fa5c7e8514aeca924fffcb1093b52 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba(_c9a9d977fdad5454babc00ddaab63396_f31dca0ecf1b4392b292cca5b8b862ba command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f(_c9a9d977fdad5454babc00ddaab63396_ca3d23ab98db459f9daaec95303a9a7f command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f(_c9a9d977fdad5454babc00ddaab63396_f38f0fae5a3842929ef6750bfa36ed4f command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507(_c9a9d977fdad5454babc00ddaab63396_04c05e98758945fc842d2e279a303507 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5(_c9a9d977fdad5454babc00ddaab63396_59346ec7cec9426d95da7892f0dc3df5 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c(_c9a9d977fdad5454babc00ddaab63396_a11ccfc957d14f06abeea2aefdfc015c command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb(_c9a9d977fdad5454babc00ddaab63396_ef0dbe4e379b402c8180c7961a02febb command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7(_c9a9d977fdad5454babc00ddaab63396_dd05fe8d90b542d8ac59833a7c1c56e7 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5(_c9a9d977fdad5454babc00ddaab63396_1f2abde24beb41c7a9cc770cd2d2c3f5 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294(_c9a9d977fdad5454babc00ddaab63396_0a52b31e506e429caaa201d8bf799294 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306(_c9a9d977fdad5454babc00ddaab63396_36e6792249bc4e378bdc0520686e9306 command)
		{
		}

		private void BakeCommandBinding__c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b(_c9a9d977fdad5454babc00ddaab63396_2e45a36821e94315bbc91642cf19e92b command)
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
