using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraCollisionMode")]
	public enum ENiagaraCollisionMode : long
	{
		None = 0,
		SceneGeometry = 1,
		DepthBuffer = 2,
		DistanceField = 3,
	}
}