using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityActor")]
	public partial class AEditorUtilityActor : AActor, IStaticClass
	{
		public UInputComponent EditorOnlyInputComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyInputComponent, __ReturnBuffer);

					return *(UInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorOnlyInputComponent, __InBuffer);
				}
			}
		}

		public bool bReceivesEditorInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReceivesEditorInput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReceivesEditorInput, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetReceivesEditorInput(bool bInValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReceivesEditorInput, __InBuffer);
			}
		}

		public virtual void Run()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __Run);
			}
		}

		public virtual bool GetReceivesEditorInput()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetReceivesEditorInput, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UInputComponent GetInputComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInputComponent, __ReturnBuffer);

				return *(UInputComponent*)__ReturnBuffer;
			}
		}

		private static uint __EditorOnlyInputComponent = 0;

		private static uint __bReceivesEditorInput = 0;

		private static uint __SetReceivesEditorInput = 0;

		private static uint __Run = 0;

		private static uint __GetReceivesEditorInput = 0;

		private static uint __GetInputComponent = 0;
	}
}