using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TestTypedElementInterfaceA_ImplUntyped")]
	public partial class UTestTypedElementInterfaceA_ImplUntyped : UObject, IStaticClass, ITestTypedElementInterfaceA
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TestTypedElementInterfaceA_ImplUntyped");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetDisplayName(FScriptTypedElementHandle InElementHandle, FText InNewName, bool bNotify = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bNotify;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDisplayName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FText GetDisplayName(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
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

		private static uint __SetDisplayName = 0;

		private static uint __GetDisplayName = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}