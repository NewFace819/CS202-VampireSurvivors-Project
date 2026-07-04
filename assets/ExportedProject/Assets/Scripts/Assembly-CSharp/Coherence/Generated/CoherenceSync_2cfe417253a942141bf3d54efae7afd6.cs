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
	public class CoherenceSync_2cfe417253a942141bf3d54efae7afd6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773_CommandTarget;

		private OnlineStageManager _2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a_CommandTarget;

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

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8(_2cfe417253a942141bf3d54efae7afd6_bd7cc761471145a7a8c42ed5c638c7a8 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a(_2cfe417253a942141bf3d54efae7afd6_5f092d18e0fe416685c391401fcfbd5a command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2(_2cfe417253a942141bf3d54efae7afd6_84c4ffda9ae44dd8ae086cf9f6e434b2 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d(_2cfe417253a942141bf3d54efae7afd6_afe0c702950d4320a9f05b898fde032d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af(_2cfe417253a942141bf3d54efae7afd6_9fbb64615cf1405eae53c28a45b287af command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424(_2cfe417253a942141bf3d54efae7afd6_821574bcf6394955a0f337b827252424 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca(_2cfe417253a942141bf3d54efae7afd6_44b11bebd523411391d1e4c2490096ca command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d(_2cfe417253a942141bf3d54efae7afd6_1ad24a7027f74f74a7d8176f4920703d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361(_2cfe417253a942141bf3d54efae7afd6_e242493af7744d7687761d9bdfd82361 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae(_2cfe417253a942141bf3d54efae7afd6_431b0194c8ea4b0185ee645769fcf5ae command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4(_2cfe417253a942141bf3d54efae7afd6_6c23fe71e0b244a98a497e85b45ee0f4 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d(_2cfe417253a942141bf3d54efae7afd6_555fe59152244c1d85ab4eccb6b9409d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0(_2cfe417253a942141bf3d54efae7afd6_14da8f33c065405da744d50c280565b0 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea(_2cfe417253a942141bf3d54efae7afd6_9515a8bd40064eebb4c8dbcd8ebbd8ea command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e(_2cfe417253a942141bf3d54efae7afd6_6585661fd82840a894cddbe0a4d4755e command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19(_2cfe417253a942141bf3d54efae7afd6_c18ef0170c7140f0b05605becd59ef19 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd(_2cfe417253a942141bf3d54efae7afd6_a8632778910d4e3c8601841fad9cfbcd command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd(_2cfe417253a942141bf3d54efae7afd6_622c5d09ae334064b7f6e3840ff360cd command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a(_2cfe417253a942141bf3d54efae7afd6_0c44e3a0ca994d87ac67bb3ba4d1cd4a command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5(_2cfe417253a942141bf3d54efae7afd6_c3879560fcbd48b0a262d179ea8983c5 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1(_2cfe417253a942141bf3d54efae7afd6_2b9899611d8a41aaa90e1f77c32b4eb1 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06(_2cfe417253a942141bf3d54efae7afd6_7f06d86da3224e8c902fa10de0550f06 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318(_2cfe417253a942141bf3d54efae7afd6_2596760cb32e4d40860a69739e613318 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806(_2cfe417253a942141bf3d54efae7afd6_cec53feff8fe4a9aa7edce4ff5ce2806 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f(_2cfe417253a942141bf3d54efae7afd6_a14e886e46834d078dbf2ab2d56ae34f command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5(_2cfe417253a942141bf3d54efae7afd6_9db806e5e8004687bf61f5e8ae22cfd5 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849(_2cfe417253a942141bf3d54efae7afd6_fddd955b4258475d9e63a15e839a7849 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e(_2cfe417253a942141bf3d54efae7afd6_6998125af5314350af78bbaced57563e command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311(_2cfe417253a942141bf3d54efae7afd6_3d4e9112d3f6415294a411b7a260c311 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a(_2cfe417253a942141bf3d54efae7afd6_8ea3a11374044648ae926e17e10ca76a command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c(_2cfe417253a942141bf3d54efae7afd6_aad89bd533504825abb67ca79086714c command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7(_2cfe417253a942141bf3d54efae7afd6_cc25aa00874d41de9434d0a7fe66aad7 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883(_2cfe417253a942141bf3d54efae7afd6_9ff85c6cdf424ec3a496826688813883 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486(_2cfe417253a942141bf3d54efae7afd6_f193c96558a24e8e88780acd0be57486 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199(_2cfe417253a942141bf3d54efae7afd6_af11550d7dce40a2959522d268213199 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31(_2cfe417253a942141bf3d54efae7afd6_ffe3200fd21a4a62b60946df7a5afd31 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4(_2cfe417253a942141bf3d54efae7afd6_d999b06a87fa422e960b50d5693a92f4 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2(_2cfe417253a942141bf3d54efae7afd6_37964ec1b1144ffeadcb43d54ed9dff2 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c(_2cfe417253a942141bf3d54efae7afd6_c5d72dc90bdf485e9610f06973f9ed9c command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a(_2cfe417253a942141bf3d54efae7afd6_64ef643d2ff14911a5ed6aa7beeb8f8a command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1(_2cfe417253a942141bf3d54efae7afd6_89ded1d4d85b4531ba619c6b8365eae1 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d(_2cfe417253a942141bf3d54efae7afd6_8192077a8f274967a2684f3b0c8d742d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01(_2cfe417253a942141bf3d54efae7afd6_23561a3a986940e1afd35aba5a987f01 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d(_2cfe417253a942141bf3d54efae7afd6_c5b35cac501b4b08a1e43191093b818d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75(_2cfe417253a942141bf3d54efae7afd6_c439c67598e34a228722b99d3dfe2b75 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2(_2cfe417253a942141bf3d54efae7afd6_247f4b36b12e4df8a6b9108e3396b4e2 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b(_2cfe417253a942141bf3d54efae7afd6_a7c0378a9c384c99835e4544b5e38b2b command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34(_2cfe417253a942141bf3d54efae7afd6_0362936b9d0342ee9777b3686edf1b34 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e(_2cfe417253a942141bf3d54efae7afd6_9e1472a77dd14980877263057a2cda0e command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8(_2cfe417253a942141bf3d54efae7afd6_0b41114b106e48b299b15fdc097d15d8 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec(_2cfe417253a942141bf3d54efae7afd6_1eabc2969c704a74a55a41440c85f8ec command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c(_2cfe417253a942141bf3d54efae7afd6_3564304c2d4f44719a08d171ba0d7e9c command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5(_2cfe417253a942141bf3d54efae7afd6_b1233ed0d3dd4d5eb1280d0fe61c8bf5 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b(_2cfe417253a942141bf3d54efae7afd6_58be85ab56ab4c46a66458b48f7a888b command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b(_2cfe417253a942141bf3d54efae7afd6_e81037ce720e461a81e9db49ff2eae0b command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8(_2cfe417253a942141bf3d54efae7afd6_1fa00a3d644e4c7da44cb15f008ec1e8 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1(_2cfe417253a942141bf3d54efae7afd6_9b893a2e3abe4b629046275034f11ed1 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412(_2cfe417253a942141bf3d54efae7afd6_af4ab4b9a707471ea81225c4d7b27412 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df(_2cfe417253a942141bf3d54efae7afd6_a54abab429a94a5b8ec009b33a2057df command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a(_2cfe417253a942141bf3d54efae7afd6_912da25f1dae41059e7d9d709f79126a command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4(_2cfe417253a942141bf3d54efae7afd6_8f73e6836ad64de9a176ddea2db71ff4 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695(_2cfe417253a942141bf3d54efae7afd6_bb8a7ade52db449f9eaf61868e2cd695 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411(_2cfe417253a942141bf3d54efae7afd6_ab14f3bf69b446a3ac71452e87f8b411 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351(_2cfe417253a942141bf3d54efae7afd6_98d3c653a2744227b84ee35219fa6351 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756(_2cfe417253a942141bf3d54efae7afd6_12b046174755410987c4f3ea63b4c756 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882(_2cfe417253a942141bf3d54efae7afd6_e043884031f4482f8b8c52c5174f5882 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d(_2cfe417253a942141bf3d54efae7afd6_8ddeddcc9a494c36adf32f0dfac17c6d command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c(_2cfe417253a942141bf3d54efae7afd6_ef18f22ac035428fabc0566fe31fb77c command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14(_2cfe417253a942141bf3d54efae7afd6_1520f2c8f0694491b0cf3330d7e06c14 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56(_2cfe417253a942141bf3d54efae7afd6_f341d471180a4c04b63c1086e01d9f56 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7(_2cfe417253a942141bf3d54efae7afd6_fd876e4d4d6c4615bda392cf7f5be4d7 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f(_2cfe417253a942141bf3d54efae7afd6_6f874449111b455ba6f731347362565f command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b(_2cfe417253a942141bf3d54efae7afd6_778449b73e994bf3834179e1bc64a98b command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e(_2cfe417253a942141bf3d54efae7afd6_c05c65104b3146efbabd32bf67d7bd1e command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532(_2cfe417253a942141bf3d54efae7afd6_27909a7c6e484ebbb0962feb3888f532 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773(_2cfe417253a942141bf3d54efae7afd6_9a5d697528024692b133b4321753d773 command)
		{
		}

		private void BakeCommandBinding__2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a(_2cfe417253a942141bf3d54efae7afd6_ae0b8b58fcdb44dc8146870186b3fe2a command)
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
