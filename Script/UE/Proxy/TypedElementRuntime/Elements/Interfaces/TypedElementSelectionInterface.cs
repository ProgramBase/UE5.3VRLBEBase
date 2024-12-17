using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementSelectionInterface")]
	public partial class UTypedElementSelectionInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementRuntime.TypedElementSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementRuntime.TypedElementSelectionInterface")]
	public interface ITypedElementSelectionInterface : IInterface
	{
		 bool SelectElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementSelectionOptions InSelectionOptions);

		 bool IsElementSelected(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementIsSelectedOptions InSelectionOptions);

		 FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InCurrentSelection, ETypedElementSelectionMethod InSelectionMethod);

		 bool DeselectElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementSelectionOptions InSelectionOptions);

		 bool CanSelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions);

		 bool CanDeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions);

		 bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet);
	}
}