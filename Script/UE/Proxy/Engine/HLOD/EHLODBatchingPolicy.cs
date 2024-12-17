using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHLODBatchingPolicy")]
	public enum EHLODBatchingPolicy : byte
	{
		None = 0,
		MeshSection = 1,
		Instancing = 2,
	}
}