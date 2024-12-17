using Script.CoreUObject;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.EAnimDataEvalType")]
	public enum EAnimDataEvalType : byte
	{
		Source = 0,
		Raw = 1,
		Compressed = 2,
	}
}