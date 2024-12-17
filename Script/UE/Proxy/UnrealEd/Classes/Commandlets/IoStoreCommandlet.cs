using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.IoStoreCommandlet")]
	public partial class UIoStoreCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.IoStoreCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}