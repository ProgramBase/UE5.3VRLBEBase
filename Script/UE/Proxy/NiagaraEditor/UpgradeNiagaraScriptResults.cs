using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.UpgradeNiagaraScriptResults")]
	public partial class UUpgradeNiagaraScriptResults : UObject, IStaticClass
	{
		public bool bCancelledByPythonError
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelledByPythonError, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelledByPythonError, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraPythonScriptModuleInput> OldInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OldInputs, __ReturnBuffer);

					return *(TArray<UNiagaraPythonScriptModuleInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OldInputs, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraPythonScriptModuleInput> NewInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NewInputs, __ReturnBuffer);

					return *(TArray<UNiagaraPythonScriptModuleInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NewInputs, __InBuffer);
				}
			}
		}

		public UNiagaraPythonScriptModuleInput DummyInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DummyInput, __ReturnBuffer);

					return *(UNiagaraPythonScriptModuleInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DummyInput, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.UpgradeNiagaraScriptResults");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVec4Input(FString InputName, FVector4 Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVec4Input, __InBuffer);
			}
		}

		public virtual void SetVec3Input(FString InputName, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVec3Input, __InBuffer);
			}
		}

		public virtual void SetVec2Input(FString InputName, FVector2D Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVec2Input, __InBuffer);
			}
		}

		public virtual void SetQuatInput(FString InputName, FQuat Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetQuatInput, __InBuffer);
			}
		}

		public virtual void SetNewInput(FString InputName, UNiagaraPythonScriptModuleInput Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNewInput, __InBuffer);
			}
		}

		public virtual void SetLinkedInput(FString InputName, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinkedInput, __InBuffer);
			}
		}

		public virtual void SetIntInput(FString InputName, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntInput, __InBuffer);
			}
		}

		public virtual void SetFloatInput(FString InputName, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFloatInput, __InBuffer);
			}
		}

		public virtual void SetEnumInput(FString InputName, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnumInput, __InBuffer);
			}
		}

		public virtual void SetColorInput(FString InputName, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorInput, __InBuffer);
			}
		}

		public virtual void SetBoolInput(FString InputName, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoolInput, __InBuffer);
			}
		}

		public virtual void ResetToDefault(FString InputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetToDefault, __InBuffer);
			}
		}

		public virtual UNiagaraPythonScriptModuleInput GetOldInput(FString InputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOldInput, __InBuffer, __ReturnBuffer);

				return *(UNiagaraPythonScriptModuleInput*)__ReturnBuffer;
			}
		}

		private static uint __bCancelledByPythonError = 0;

		private static uint __OldInputs = 0;

		private static uint __NewInputs = 0;

		private static uint __DummyInput = 0;

		private static uint __SetVec4Input = 0;

		private static uint __SetVec3Input = 0;

		private static uint __SetVec2Input = 0;

		private static uint __SetQuatInput = 0;

		private static uint __SetNewInput = 0;

		private static uint __SetLinkedInput = 0;

		private static uint __SetIntInput = 0;

		private static uint __SetFloatInput = 0;

		private static uint __SetEnumInput = 0;

		private static uint __SetColorInput = 0;

		private static uint __SetBoolInput = 0;

		private static uint __ResetToDefault = 0;

		private static uint __GetOldInput = 0;
	}
}