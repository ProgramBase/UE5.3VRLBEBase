using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlueprintFunctionLibraryFactory")]
	public partial class UBlueprintFunctionLibraryFactory : UBlueprintFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BlueprintFunctionLibraryFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}