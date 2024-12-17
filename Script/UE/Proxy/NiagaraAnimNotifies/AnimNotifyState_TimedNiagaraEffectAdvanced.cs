using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraAnimNotifies
{
	[PathName("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced")]
	public partial class UAnimNotifyState_TimedNiagaraEffectAdvanced : UAnimNotifyState_TimedNiagaraEffect, IStaticClass
	{
		public bool bEnableNormalizedNotifyProgress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNormalizedNotifyProgress, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNormalizedNotifyProgress, __InBuffer);
				}
			}
		}

		public FName NotifyProgressUserParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyProgressUserParameter, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyProgressUserParameter, __InBuffer);
				}
			}
		}

		public TArray<FCurveParameterPair> AnimCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimCurves, __ReturnBuffer);

					return *(TArray<FCurveParameterPair>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimCurves, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual float GetNotifyProgress(UMeshComponent MeshComp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshComp?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNotifyProgress, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __bEnableNormalizedNotifyProgress = 0;

		private static uint __NotifyProgressUserParameter = 0;

		private static uint __AnimCurves = 0;

		private static uint __GetNotifyProgress = 0;
	}
}