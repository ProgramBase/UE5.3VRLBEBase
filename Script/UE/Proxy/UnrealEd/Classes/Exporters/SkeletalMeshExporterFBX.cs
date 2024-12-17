using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SkeletalMeshExporterFBX")]
	public partial class USkeletalMeshExporterFBX : UExporterFBX, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SkeletalMeshExporterFBX");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}