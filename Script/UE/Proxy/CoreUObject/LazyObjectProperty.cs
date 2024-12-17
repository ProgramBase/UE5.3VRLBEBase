using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.LazyObjectProperty")]
	public partial class ULazyObjectProperty : UObjectPropertyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.LazyObjectProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}