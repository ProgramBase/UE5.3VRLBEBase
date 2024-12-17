using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBlendMode")]
	public enum EBlendMode : byte
	{
		BLEND_Opaque = 0,
		BLEND_Masked = 1,
		BLEND_Translucent = 2,
		BLEND_Additive = 3,
		BLEND_Modulate = 4,
		BLEND_AlphaComposite = 5,
		BLEND_AlphaHoldout = 6,
		BLEND_TranslucentColoredTransmittance = 7,
	}
}