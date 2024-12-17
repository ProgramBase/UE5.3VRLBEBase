using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentElementHierarchyInterface")]
	public partial class UComponentElementHierarchyInterface : UObject, IStaticClass, ITypedElementHierarchyInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ComponentElementHierarchyInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle, bool bAllowCreate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCreate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentElement, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Appends to OutElementHandles.
		/// </note>
		public virtual void GetChildElements(FScriptTypedElementHandle InElementHandle, ref TArray<FScriptTypedElementHandle> OutElementHandles, bool bAllowCreate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutElementHandles?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAllowCreate;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetChildElements, __InBuffer, __OutBuffer);

				OutElementHandles = *(TArray<FScriptTypedElementHandle>*)(__OutBuffer);

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

		private static uint __GetParentElement = 0;

		private static uint __GetChildElements = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}