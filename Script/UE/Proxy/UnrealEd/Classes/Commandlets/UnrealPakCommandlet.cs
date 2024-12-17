using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UnrealPakCommandlet")]
	public partial class UUnrealPakCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UnrealPakCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}