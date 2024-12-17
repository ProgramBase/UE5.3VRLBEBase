using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PackageMap")]
	public partial class UPackageMap : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.PackageMap");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}