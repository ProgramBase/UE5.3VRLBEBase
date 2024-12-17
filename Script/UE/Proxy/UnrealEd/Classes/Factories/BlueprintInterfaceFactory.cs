using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlueprintInterfaceFactory")]
	public partial class UBlueprintInterfaceFactory : UBlueprintFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BlueprintInterfaceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}