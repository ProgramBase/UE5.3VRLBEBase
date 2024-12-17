using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AutoReimportManager")]
	public partial class UAutoReimportManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AutoReimportManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}