using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoneReferenceSkeletonProvider")]
	public partial class UBoneReferenceSkeletonProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BoneReferenceSkeletonProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.BoneReferenceSkeletonProvider")]
	public interface IBoneReferenceSkeletonProvider : IInterface
	{
	}
}