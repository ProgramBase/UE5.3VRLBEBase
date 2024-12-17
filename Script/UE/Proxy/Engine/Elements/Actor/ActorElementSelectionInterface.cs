using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorElementSelectionInterface")]
	public partial class UActorElementSelectionInterface : UObject, IStaticClass, ITypedElementSelectionInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorElementSelectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// True if the selection was changed, false otherwise.
		/// </returns>
		public virtual bool SelectElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementSelectionOptions InSelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsElementSelected(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementIsSelectedOptions InSelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsElementSelected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InCurrentSelection, ETypedElementSelectionMethod InSelectionMethod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCurrentSelection?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InSelectionMethod;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSelectionElement, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the selection was changed, false otherwise.
		/// </returns>
		public virtual bool DeselectElement(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet, FTypedElementSelectionOptions InSelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeselectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanSelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanSelectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanDeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanDeselectElement, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle, FScriptTypedElementListProxy InSelectionSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSelectionSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AllowSelectionModifiers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __SelectElement = 0;

		private static uint __IsElementSelected = 0;

		private static uint __GetSelectionElement = 0;

		private static uint __DeselectElement = 0;

		private static uint __CanSelectElement = 0;

		private static uint __CanDeselectElement = 0;

		private static uint __AllowSelectionModifiers = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}