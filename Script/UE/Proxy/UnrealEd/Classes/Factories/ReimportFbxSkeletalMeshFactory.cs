using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportFbxSkeletalMeshFactory")]
	public partial class UReimportFbxSkeletalMeshFactory : UFbxFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportFbxSkeletalMeshFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}