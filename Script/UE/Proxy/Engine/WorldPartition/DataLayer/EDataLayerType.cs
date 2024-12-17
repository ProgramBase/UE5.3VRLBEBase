using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDataLayerType")]
	public enum EDataLayerType : byte
	{
		Runtime = 0,
		Editor = 1,
		Unknown = 2,
		Size = 3,
	}
}