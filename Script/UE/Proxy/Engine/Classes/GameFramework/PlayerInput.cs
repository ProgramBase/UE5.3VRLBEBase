using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerInput")]
	public partial class UPlayerInput : UObject, IStaticClass
	{
		public TArray<FKeyBind> DebugExecBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugExecBindings, __ReturnBuffer);

					return *(TArray<FKeyBind>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugExecBindings, __InBuffer);
				}
			}
		}

		public TArray<FName> InvertedAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InvertedAxis, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InvertedAxis, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerInput");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetMouseSensitivity(float Sensitivity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Sensitivity;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMouseSensitivity, __InBuffer);
			}
		}

		public virtual void SetBind(FName BindName, FString Command)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BindName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Command?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBind, __InBuffer);
			}
		}

		public virtual void InvertAxisKey(FKey AxisKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AxisKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InvertAxisKey, __InBuffer);
			}
		}

		public virtual void InvertAxis(FName AxisName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AxisName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InvertAxis, __InBuffer);
			}
		}

		public virtual APlayerController GetOuterAPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOuterAPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual void ClearSmoothing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSmoothing);
			}
		}

		private static uint __DebugExecBindings = 0;

		private static uint __InvertedAxis = 0;

		private static uint __SetMouseSensitivity = 0;

		private static uint __SetBind = 0;

		private static uint __InvertAxisKey = 0;

		private static uint __InvertAxis = 0;

		private static uint __GetOuterAPlayerController = 0;

		private static uint __ClearSmoothing = 0;
	}
}