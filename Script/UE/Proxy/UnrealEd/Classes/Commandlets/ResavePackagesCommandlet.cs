using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ResavePackagesCommandlet")]
	public partial class UResavePackagesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ResavePackagesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}