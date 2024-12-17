using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECustomMaterialOutputType")]
	public enum ECustomMaterialOutputType : byte
	{
		CMOT_Float1 = 0,
		CMOT_Float2 = 1,
		CMOT_Float3 = 2,
		CMOT_Float4 = 3,
		CMOT_MaterialAttributes = 4,
	}
}