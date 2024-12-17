using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Function")]
	public partial class UFunction : UStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Function");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}