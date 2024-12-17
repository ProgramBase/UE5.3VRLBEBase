using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UnrealEdTypes")]
	public partial class UUnrealEdTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UnrealEdTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}