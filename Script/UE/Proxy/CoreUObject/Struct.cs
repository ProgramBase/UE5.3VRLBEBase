using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Struct")]
	public partial class UStruct : UField, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Struct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}