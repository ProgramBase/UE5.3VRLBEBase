using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStereoLayerShape")]
	public enum EStereoLayerShape : long
	{
		SLSH_QuadLayer = 0,
		SLSH_CylinderLayer = 1,
		SLSH_CubemapLayer = 2,
		SLSH_EquirectLayer = 3,
	}
}