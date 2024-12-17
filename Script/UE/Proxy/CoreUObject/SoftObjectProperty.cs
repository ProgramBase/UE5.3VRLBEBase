using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SoftObjectProperty")]
	public partial class USoftObjectProperty : UObjectPropertyBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.SoftObjectProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}