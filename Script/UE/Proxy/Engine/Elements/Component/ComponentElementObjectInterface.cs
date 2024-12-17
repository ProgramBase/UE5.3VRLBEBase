using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;
using Script.TypedElementFramework;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentElementObjectInterface")]
	public partial class UComponentElementObjectInterface : UObject, IStaticClass, ITypedElementObjectInterface
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ComponentElementObjectInterface");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UClass GetObjectClass(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetObjectClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual UObject GetObject(FScriptTypedElementHandle InElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
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

		private static uint __GetObjectClass = 0;

		private static uint __GetObject = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}