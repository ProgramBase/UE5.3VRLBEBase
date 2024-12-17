using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.LinkerPlaceholderFunction")]
	public partial class ULinkerPlaceholderFunction : UFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.LinkerPlaceholderFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}