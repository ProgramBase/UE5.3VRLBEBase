using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialPositionTransformSource")]
	public enum EMaterialPositionTransformSource : byte
	{
		TRANSFORMPOSSOURCE_Local = 0,
		TRANSFORMPOSSOURCE_World = 1,
		TRANSFORMPOSSOURCE_TranslatedWorld = 2,
		TRANSFORMPOSSOURCE_View = 3,
		TRANSFORMPOSSOURCE_Camera = 4,
		TRANSFORMPOSSOURCE_Particle = 5,
		TRANSFORMPOSSOURCE_Instance = 6,
	}
}