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
	public class CoherenceSync_aa8b165cabacc0042aced6f611ac8e53 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684_CommandTarget;

		private CharacterController _aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02_CommandTarget;

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

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6(_aa8b165cabacc0042aced6f611ac8e53_9f211add100b41fc99ca986429ad75e6 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc(_aa8b165cabacc0042aced6f611ac8e53_864644817d704eda8634241b172d77cc command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11(_aa8b165cabacc0042aced6f611ac8e53_af9d7e227329480c82b12ba853ac4f11 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502(_aa8b165cabacc0042aced6f611ac8e53_9a5d99488d674c2e8882f35e0311d502 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879(_aa8b165cabacc0042aced6f611ac8e53_98e0f28b34e44af0adc143dc58b9f879 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51(_aa8b165cabacc0042aced6f611ac8e53_7c73cb554d984d52b017ab011d070d51 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc(_aa8b165cabacc0042aced6f611ac8e53_e0bb5fbf50bd4fa3911adf0104d6fbdc command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6(_aa8b165cabacc0042aced6f611ac8e53_0876200d70bf45a78f3e6d3e84f3faf6 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd(_aa8b165cabacc0042aced6f611ac8e53_0f385db768c34080bd8b71c6c221e4bd command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72(_aa8b165cabacc0042aced6f611ac8e53_fd42e14d37754ad993f0fca742a37d72 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7(_aa8b165cabacc0042aced6f611ac8e53_475a0aada229495295662bac775b28c7 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684(_aa8b165cabacc0042aced6f611ac8e53_82b5009993d14caba8921b622b6e4684 command)
		{
		}

		private void BakeCommandBinding__aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02(_aa8b165cabacc0042aced6f611ac8e53_022cbedc6cb24098b46022bf942fae02 command)
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
