using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementDataStorageFactory")]
	public partial class UTypedElementDataStorageFactory : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementDataStorageFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}