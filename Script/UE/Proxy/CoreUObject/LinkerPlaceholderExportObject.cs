using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.LinkerPlaceholderExportObject")]
	public partial class ULinkerPlaceholderExportObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.LinkerPlaceholderExportObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}