using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DeviceTriggerTriggerVibrationData")]
	public partial class FDeviceTriggerTriggerVibrationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DeviceTriggerTriggerVibrationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDeviceTriggerTriggerVibrationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDeviceTriggerTriggerVibrationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDeviceTriggerTriggerVibrationData A, FDeviceTriggerTriggerVibrationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDeviceTriggerTriggerVibrationData A, FDeviceTriggerTriggerVibrationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDeviceTriggerTriggerVibrationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveFloat TriggerPositionCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriggerPositionCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriggerPositionCurve, __InBuffer);
				}
			}
		}

		public UCurveFloat VibrationFrequencyCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VibrationFrequencyCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VibrationFrequencyCurve, __InBuffer);
				}
			}
		}

		public UCurveFloat VibrationAmplitudeCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VibrationAmplitudeCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VibrationAmplitudeCurve, __InBuffer);
				}
			}
		}

		private static uint __TriggerPositionCurve = 0;

		private static uint __VibrationFrequencyCurve = 0;

		private static uint __VibrationAmplitudeCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}