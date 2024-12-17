using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DumpHiddenCategoriesCommandlet")]
	public partial class UDumpHiddenCategoriesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DumpHiddenCategoriesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}