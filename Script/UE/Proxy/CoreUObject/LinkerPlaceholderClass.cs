using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.LinkerPlaceholderClass")]
	public partial class ULinkerPlaceholderClass : UClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.LinkerPlaceholderClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}