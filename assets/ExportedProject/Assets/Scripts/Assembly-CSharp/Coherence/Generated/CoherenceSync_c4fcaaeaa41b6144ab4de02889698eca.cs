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
	public class CoherenceSync_c4fcaaeaa41b6144ab4de02889698eca : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70_CommandTarget;

		private CharacterController _c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142_CommandTarget;

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

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a(_c4fcaaeaa41b6144ab4de02889698eca_24ec0f1b8b15483fab231c2ea61dac4a command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b(_c4fcaaeaa41b6144ab4de02889698eca_06da3ce3a9354b44a4747d8b933dff5b command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4(_c4fcaaeaa41b6144ab4de02889698eca_a9cc23e0c948478bbabf2afc87f147e4 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af(_c4fcaaeaa41b6144ab4de02889698eca_d9d6cdbc2c4a4d4799a53a93151b86af command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058(_c4fcaaeaa41b6144ab4de02889698eca_8dcfed015df6468cb393309b93c40058 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75(_c4fcaaeaa41b6144ab4de02889698eca_4f68971d79604224a4fec37c95201d75 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001(_c4fcaaeaa41b6144ab4de02889698eca_6a8b1f678b524c5880b3f8d62c48e001 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b(_c4fcaaeaa41b6144ab4de02889698eca_bc490227509e4113a018b627d83e508b command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389(_c4fcaaeaa41b6144ab4de02889698eca_7b2bfc4939a0494eab9c833146164389 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474(_c4fcaaeaa41b6144ab4de02889698eca_f3df2ef1e1b04a07b11d2a4c035cc474 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130(_c4fcaaeaa41b6144ab4de02889698eca_66a3da69f0444d91b94d081c0a025130 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70(_c4fcaaeaa41b6144ab4de02889698eca_a43b96f2afcf4bafae2c8e88bbdc7c70 command)
		{
		}

		private void BakeCommandBinding__c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142(_c4fcaaeaa41b6144ab4de02889698eca_400fe228ccfc49f2be3f7192e10b6142 command)
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
