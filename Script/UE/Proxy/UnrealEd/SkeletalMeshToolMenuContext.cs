using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SkeletalMeshToolMenuContext")]
	public partial class USkeletalMeshToolMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SkeletalMeshToolMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}