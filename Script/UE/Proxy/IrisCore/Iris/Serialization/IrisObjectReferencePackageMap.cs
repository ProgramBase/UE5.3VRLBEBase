using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.IrisObjectReferencePackageMap")]
	public partial class UIrisObjectReferencePackageMap : UPackageMap, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.IrisObjectReferencePackageMap");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}