using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementObjectInterface")]
	public partial class UTypedElementObjectInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementObjectInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementRuntime.TypedElementObjectInterface")]
	public interface ITypedElementObjectInterface : IInterface
	{
		 UClass GetObjectClass(FScriptTypedElementHandle InElementHandle);

		 UObject GetObject(FScriptTypedElementHandle InElementHandle);
	}
}