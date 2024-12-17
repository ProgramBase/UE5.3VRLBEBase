using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.WeakObjectProperty")]
	public partial class UWeakObjectProperty : UObjectPropertyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.WeakObjectProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}