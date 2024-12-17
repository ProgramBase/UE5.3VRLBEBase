using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GenerateBlueprintAPICommandlet")]
	public partial class UGenerateBlueprintAPICommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GenerateBlueprintAPICommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}