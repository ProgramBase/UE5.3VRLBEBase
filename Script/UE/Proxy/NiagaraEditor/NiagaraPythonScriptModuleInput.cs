using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput")]
	public partial class UNiagaraPythonScriptModuleInput : UObject, IStaticClass
	{
		public UNiagaraClipboardFunctionInput Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(UNiagaraClipboardFunctionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSet, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLocalValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocalValue, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLinkedValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLinkedValue, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector4 AsVec4()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsVec4, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public virtual FVector AsVec3()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsVec3, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector2D AsVec2()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsVec2, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FQuat AsQuat()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsQuat, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public virtual FString AsLinkedValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsLinkedValue, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int AsInt()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AsInt, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float AsFloat()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AsFloat, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FString AsEnum()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsEnum, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor AsColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AsColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual bool AsBool()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __AsBool, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Input = 0;

		private static uint __IsSet = 0;

		private static uint __IsLocalValue = 0;

		private static uint __IsLinkedValue = 0;

		private static uint __AsVec4 = 0;

		private static uint __AsVec3 = 0;

		private static uint __AsVec2 = 0;

		private static uint __AsQuat = 0;

		private static uint __AsLinkedValue = 0;

		private static uint __AsInt = 0;

		private static uint __AsFloat = 0;

		private static uint __AsEnum = 0;

		private static uint __AsColor = 0;

		private static uint __AsBool = 0;
	}
}