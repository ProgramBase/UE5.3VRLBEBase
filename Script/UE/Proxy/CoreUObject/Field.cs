using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Field")]
	public partial class UField : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Field");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}