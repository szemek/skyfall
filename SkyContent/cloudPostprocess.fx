texture cloudLight;
sampler2D cloudLightSampler = sampler_state {
    Texture = (cloudLight);
    MinFilter = Linear;
    MagFilter = Linear;
    AddressU = Clamp;
    AddressV = Clamp;
};

texture distortion;
sampler2D distortionSampler = sampler_state
{
	texture = distortion;
	MagFilter = Linear;
	MinFilter = Linear;
};


float sampleOffsets[13] = {
    -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6
};

float sampleWeights[13] = {
    0.002216,
    0.008764,
    0.026995,
    0.064759,
    0.120985,
    0.176033,
    0.199471,
    0.176033,
    0.120985,
    0.064759,
    0.026995,
    0.008764,
    0.002216,
};

float offset;
float hardness;
float frequency;
float amplitude;

struct VSOUTPUT
{
	float4 pos : POSITION;
	float2 uv : TEXCOORD0;
};


VSOUTPUT vsmain(float4 pos : POSITION)
{
	VSOUTPUT o;
	o.pos = pos;
	o.uv = float2(1, -1) * pos.xy * 0.5 + 0.5;
	
	return o;
}


float4 blurV(float2 uv : TEXCOORD0) : COLOR
{
	float4 color = 0;
	for (int i=0; i<13; i++)
	{
		color += sampleWeights[i] * tex2D(cloudLightSampler, uv + float2(0, sampleOffsets[i]*offset));
	}
	return color;
}


float4 blurH(float2 uv : TEXCOORD0) : COLOR
{
	float4 color = 0;
	for (int i=0; i<13; i++)
	{
		color += sampleWeights[i] * tex2D(cloudLightSampler, uv + float2(sampleOffsets[i]*offset, 0));
	}
	return color;
}

float4 distort(float2 uv : TEXCOORD0) : COLOR
{
	//float3 pos = tex2D(position, uv).xyz;
   
	float2 offset = amplitude * (tex2D(distortionSampler, frequency*uv.xy).xy - 0.5);

	float4 color = tex2D( cloudLightSampler, uv+offset);
	color *= pow(color.a, hardness);

	return color;
}

 
technique postprocess
{
    pass blurV
    {
        VertexShader = compile vs_3_0 vsmain();
        PixelShader = compile ps_3_0 blurV();
    }

	pass blurH
    {
        VertexShader = compile vs_3_0 vsmain();
        PixelShader = compile ps_3_0 blurH();
    }

	pass distort
    {
        VertexShader = compile vs_3_0 vsmain();
        PixelShader = compile ps_3_0 distort();
    }
}