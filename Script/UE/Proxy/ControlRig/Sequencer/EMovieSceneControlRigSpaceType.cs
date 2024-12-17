using Script.CoreUObject;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EMovieSceneControlRigSpaceType")]
	public enum EMovieSceneControlRigSpaceType : byte
	{
		Parent = 0,
		World = 1,
		ControlRig = 2,
	}
}