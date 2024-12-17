using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialParameterAssociation")]
	public enum EMaterialParameterAssociation : byte
	{
		LayerParameter = 0,
		BlendParameter = 1,
		GlobalParameter = 2,
	}
}