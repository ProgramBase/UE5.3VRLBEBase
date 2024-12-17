using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineElementsLibrary")]
	public partial class UEngineElementsLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineElementsLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FScriptTypedElementHandle K2_AcquireEditorSMInstanceElementHandle(UInstancedStaticMeshComponent ISMComponent, int InstanceIndex, bool bAllowCreate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ISMComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InstanceIndex;

				*(bool*)(__InBuffer + 12) = bAllowCreate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AcquireEditorSMInstanceElementHandle, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		public static FScriptTypedElementHandle K2_AcquireEditorObjectElementHandle(UObject Object, bool bAllowCreate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCreate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AcquireEditorObjectElementHandle, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		public static FScriptTypedElementHandle K2_AcquireEditorComponentElementHandle(UActorComponent Component, bool bAllowCreate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCreate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AcquireEditorComponentElementHandle, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		public static FScriptTypedElementHandle K2_AcquireEditorActorElementHandle(AActor Actor, bool bAllowCreate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCreate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AcquireEditorActorElementHandle, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		private static uint __K2_AcquireEditorSMInstanceElementHandle = 0;

		private static uint __K2_AcquireEditorObjectElementHandle = 0;

		private static uint __K2_AcquireEditorComponentElementHandle = 0;

		private static uint __K2_AcquireEditorActorElementHandle = 0;
	}
}