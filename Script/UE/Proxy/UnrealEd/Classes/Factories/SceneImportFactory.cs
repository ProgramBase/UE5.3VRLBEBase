using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SceneImportFactory")]
	public partial class USceneImportFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SceneImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}