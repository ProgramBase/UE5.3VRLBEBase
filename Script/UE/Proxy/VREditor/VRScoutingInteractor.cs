using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.ViewportInteraction;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VRScoutingInteractor")]
	public partial class UVRScoutingInteractor : UVREditorInteractor, IStaticClass
	{
		public UStaticMeshComponent FlyingIndicatorComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FlyingIndicatorComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FlyingIndicatorComponent, __InBuffer);
				}
			}
		}

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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VRScoutingInteractor");
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

		public virtual void SetGizmoMode(EGizmoHandleTypes InGizmoMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InGizmoMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGizmoMode, __InBuffer);
			}
		}

		public static TArray<AActor> GetSelectedActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
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

		public virtual EGizmoHandleTypes GetGizmoMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGizmoMode, __ReturnBuffer);

				return *(EGizmoHandleTypes*)__ReturnBuffer;
			}
		}

		private static uint __FlyingIndicatorComponent = 0;

		private static uint __EditorOnlyInputComponent = 0;

		private static uint __bReceivesEditorInput = 0;

		private static uint __SetReceivesEditorInput = 0;

		private static uint __SetGizmoMode = 0;

		private static uint __GetSelectedActors = 0;

		private static uint __GetReceivesEditorInput = 0;

		private static uint __GetInputComponent = 0;

		private static uint __GetGizmoMode = 0;
	}
}