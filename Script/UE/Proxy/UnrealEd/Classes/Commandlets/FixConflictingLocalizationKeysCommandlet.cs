using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FixConflictingLocalizationKeysCommandlet")]
	public partial class UFixConflictingLocalizationKeysCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.FixConflictingLocalizationKeysCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}