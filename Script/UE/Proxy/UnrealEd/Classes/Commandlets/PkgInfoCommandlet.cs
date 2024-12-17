using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PkgInfoCommandlet")]
	public partial class UPkgInfoCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PkgInfoCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}