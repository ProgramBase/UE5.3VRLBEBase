using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.SMInstanceElementPrimitiveCustomDataInterface")]
	public partial class USMInstanceElementPrimitiveCustomDataInterface : UObject, IStaticClass, ITypedElementPrimitiveCustomDataInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SMInstanceElementPrimitiveCustomDataInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetCustomDataValue(FScriptTypedElementHandle InElementHandle, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = CustomDataIndex;

				*(float*)(__InBuffer + 12) = CustomDataValue;

				*(bool*)(__InBuffer + 16) = bMarkRenderStateDirty;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomDataValue, __InBuffer);
			}
		}

		public virtual void SetCustomData(FScriptTypedElementHandle InElementHandle, TArray<float> CustomDataFloats, bool bMarkRenderStateDirty = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CustomDataFloats?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMarkRenderStateDirty;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomData, __InBuffer);
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

		private static uint __SetCustomDataValue = 0;

		private static uint __SetCustomData = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}