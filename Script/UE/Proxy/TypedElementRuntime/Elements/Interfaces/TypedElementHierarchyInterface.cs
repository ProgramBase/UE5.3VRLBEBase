using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementHierarchyInterface")]
	public partial class UTypedElementHierarchyInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementHierarchyInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementRuntime.TypedElementHierarchyInterface")]
	public interface ITypedElementHierarchyInterface : IInterface
	{
		 FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle, bool bAllowCreate = true);

		 void GetChildElements(FScriptTypedElementHandle InElementHandle, ref TArray<FScriptTypedElementHandle> OutElementHandles, bool bAllowCreate);
	}
}