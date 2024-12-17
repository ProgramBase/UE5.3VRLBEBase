using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlueprintMacroFactory")]
	public partial class UBlueprintMacroFactory : UBlueprintFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BlueprintMacroFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}