Shader "VampireSurvivors/WaveDeformShader" {
	Properties {
		_MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
		_VerticalWaveAmplitude ("Vertical Wave Amplitude", Float) = 0.2
		_HorizontalWaveAmplitude ("Horizontal Wave Amplitude", Float) = 0.4
		_VerticalWaveInputAmplitude ("Vertical Wave Input Amplitude", Range(-1, 1)) = 1
		_HorizontalWaveInputAmplitude ("Horizontal Wave Input Amplitude", Range(-1, 1)) = 1
		_VerticalWaveFrequency ("Vertical Wave Frequency", Float) = 1
		_HorizontalWaveFrequency ("Horizontal Wave Frequency", Float) = 2
		_WaveSpeed ("Wave Speed", Float) = 2.5
		[Toggle(FLIP_NORMALISEDANIM_FADEIN)] _FlipNormalisedFadein ("Flip Normalised Fadein", Float) = 0
		[Toggle(FLIP_NORMALISEDANIM_DISTORT)] _FlipNormalisedDistort ("Flip Normalised Distort", Float) = 0
		_NormalisedAnim ("Normalised Animation", Range(0, 1)) = 1
		[Toggle(PAUSE_SYSTEM_TIME)] _PauseToggle ("Pause Time", Float) = 0
		_PauseTime ("Pause time", Float) = 1
		[Toggle(USE_VERTEX_COLOR_MULTIPLY)] _UseVertexColorMultiply ("Use Vertex Color Multiply", Float) = 0
		[Toggle(USE_VERTEX_ALPHA_OFFSET)] _UseVertexAlphaOffset ("Use Vertex Alpha Offset", Float) = 0
		[Toggle(USE_CONTROLLERINPUTS)] _UseControllerInputs ("Use Controller Inputs", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}