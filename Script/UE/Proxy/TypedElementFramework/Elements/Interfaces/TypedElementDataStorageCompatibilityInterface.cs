using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementDataStorageCompatibilityInterface")]
	public partial class UTypedElementDataStorageCompatibilityInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementDataStorageCompatibilityInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TypedElementDataStorageCompatibilityInterface")]
	public interface ITypedElementDataStorageCompatibilityInterface : IInterface
	{
	}
}