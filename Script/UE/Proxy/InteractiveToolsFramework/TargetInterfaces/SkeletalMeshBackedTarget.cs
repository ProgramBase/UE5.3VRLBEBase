using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.SkeletalMeshBackedTarget")]
	public partial class USkeletalMeshBackedTarget : UAssetBackedTarget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.SkeletalMeshBackedTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.SkeletalMeshBackedTarget")]
	public interface ISkeletalMeshBackedTarget : IAssetBackedTarget
	{
	}
}