float4x4 worldViewProj;
float4x4 worldView;
float3 sunDir;
float3 color = float3(0.8,0.8,0.8);

float scatteredMin;
float scatteredMax;
float dirMin;
float dirMax;
float dirExp;
float constant;

struct VSOUTPUT
{
	float4 pos : POSITION;
	float3 normal : TEXCOORD0;
	float3 normalView : TEXCOORD1;
	float3 viewDir : TEXCOORD2;
};


VSOUTPUT vsmain(float4 pos : POSITION,
				float3 normal : NORMAL)
{
	VSOUTPUT o;
	o.pos = mul(pos, worldViewProj);
	o.normal = normal;
	o.normalView = mul(normal, worldView);
	o.viewDir = mul(pos, worldView).xyz;

	return o;
}


float4 psmain(float3 normal : TEXCOORD0, float3 viewDir : TEXCOORD2) : COLOR
{
	float3 N = normalize(normal);
	float3 V = normalize(viewDir);

	float scattered = lerp(scatteredMin, scatteredMax, dot(N, V) * 0.5 + 0.5);
	float ndotl = pow(dot(N, sunDir) * 0.5 + 0.5, dirExp);
	float directional = lerp(dirMin, dirMax, ndotl);
	
	return float4(directional * color + scattered + constant, 1);
}

 
technique skylight
{
    pass
    {
        VertexShader = compile vs_3_0 vsmain();
        PixelShader = compile ps_3_0 psmain();
    }
}