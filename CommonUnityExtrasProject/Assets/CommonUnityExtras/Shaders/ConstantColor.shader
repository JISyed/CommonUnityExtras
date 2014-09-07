Shader "CUE/ConstantColor" 
{
	Properties 
	{
		_Color ("Color", Color) = (1,1,1,1)
	}
	
	SubShader 
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			uniform float4 _Color;
			
			struct vertexInput
			{
				float4 vertex : POSITION;
			};
			
			struct vertexOutput
			{
				float4 pos : SV_POSITION;
			};
			
			// Vertex Shader
			vertexOutput vert(vertexInput i)
			{
				vertexOutput o;
				
				o.pos = mul(UNITY_MATRIX_MVP, i.vertex);
				
				return o;
			}
			
			// Fragment Shader
			float4 frag(vertexOutput i) : COLOR
			{
				return _Color;
			}
			
			ENDCG
		}
	}
}
