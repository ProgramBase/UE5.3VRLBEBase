using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementDataStorageInterface")]
	public partial class UTypedElementDataStorageInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementDataStorageInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TypedElementDataStorageInterface")]
	public interface ITypedElementDataStorageInterface : IInterface
	{
	}
}