using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FacialAnimation
{
	[PathName("/Script/FacialAnimation.AudioCurveSourceComponent")]
	public partial class UAudioCurveSourceComponent : UAudioComponent, IStaticClass, ICurveSourceInterface
	{
		public FName CurveSourceBindingName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurveSourceBindingName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurveSourceBindingName, __InBuffer);
				}
			}
		}

		public float CurveSyncOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurveSyncOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurveSyncOffset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FacialAnimation.AudioCurveSourceComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float GetCurveValue(FName CurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCurveValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void GetCurves(ref TArray<FNamedCurveValue> OutValues)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCurves, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FNamedCurveValue>*)(__OutBuffer);

			}
		}

		public virtual FName GetBindingName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBindingName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
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

		private static uint __CurveSourceBindingName = 0;

		private static uint __CurveSyncOffset = 0;

		private static uint __GetCurveValue = 0;

		private static uint __GetCurves = 0;

		private static uint __GetBindingName = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}