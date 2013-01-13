float4x4 viewProj;
float3x3 XYZtoRGB;

float thetaS = 0.7;
float phiS = 0.0;

float turbidity;
float coeffY[5];
float coeffx[5];
float coeffy[5];
float zenithY;
float zenithx;
float zenithy;



// STRUKTURY
struct VSOUTPUT
{
	float4 pos : POSITION;
	float2 angles : TEXCOORD0;
};


// FUNKCJE POMOCNICZE
float angleBetween(float theta1, float phi1, float theta2, float phi2)
{
	float cospsi = clamp( sin(theta1) * sin(theta2) * cos(phi2-phi1) + cos(theta1) * cos(theta2), -1.0, 1.0 );
	return acos(cospsi);
}

float perezFunction(float theta, float gamma, float coeff[5])
{
	float num = ( 1 + coeff[0] * exp(coeff[1] / cos(theta)) )
		* ( 1 + coeff[2] * exp(coeff[3] * gamma) + coeff[4] * pow(cos(gamma), 2) );

	float den = ( 1 + coeff[0] * exp(coeff[1]) )
		* ( 1 + coeff[2] * exp(coeff[3] * thetaS) + coeff[4] * pow(cos(thetaS), 2) );

	return num / den;
}


// G£ÓWNE FUNKCJE SHADERÓW
VSOUTPUT vsmain(float4 pos : POSITION,
				float2 angles : TEXCOORD0)
{
	VSOUTPUT o;
	o.pos = mul(pos, viewProj);
	o.angles = angles;

	return o;
}

float4 psmain(float2 angles : TEXCOORD0) : COLOR
{
	float Y = zenithY * perezFunction(angles.y, angleBetween(angles.y, angles.x, thetaS, phiS), coeffY);
	float x = zenithx * perezFunction(angles.y, angleBetween(angles.y, angles.x, thetaS, phiS), coeffx);
	float y = zenithy * perezFunction(angles.y, angleBetween(angles.y, angles.x, thetaS, phiS), coeffy);

	Y *= 0.046;

	float3 color = float3(x/y * Y, Y, (1-x-y)/y * Y);

	color = mul(color, XYZtoRGB);

	return float4(color, 1);
}

float4 psmainDebug(float2 angles : TEXCOORD0) : COLOR
{
	return float4(angles.x*0.25, angles.y*0.5, 0, 1);
}
 
technique skylight
{
    pass
    {
        VertexShader = compile vs_3_0 vsmain();
        PixelShader = compile ps_3_0 psmain();
    }
}