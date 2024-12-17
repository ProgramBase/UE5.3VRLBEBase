using Script.CoreUObject;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.ESpawnOwnership")]
	public enum ESpawnOwnership : byte
	{
		InnerSequence = 0,
		RootSequence = 1,
		External = 2,
	}
}