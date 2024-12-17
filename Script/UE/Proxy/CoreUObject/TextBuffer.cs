using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TextBuffer")]
	public partial class UTextBuffer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.TextBuffer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}