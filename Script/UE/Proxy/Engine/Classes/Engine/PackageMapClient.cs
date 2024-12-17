using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PackageMapClient")]
	public partial class UPackageMapClient : UPackageMap, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PackageMapClient");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}