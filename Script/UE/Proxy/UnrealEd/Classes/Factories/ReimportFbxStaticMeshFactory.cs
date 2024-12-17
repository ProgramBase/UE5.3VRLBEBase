using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportFbxStaticMeshFactory")]
	public partial class UReimportFbxStaticMeshFactory : UFbxFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportFbxStaticMeshFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}