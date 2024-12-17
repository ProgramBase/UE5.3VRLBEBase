using Script.CoreUObject;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.MeterChannelInfo")]
	public partial class FMeterChannelInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioWidgets.MeterChannelInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMeterChannelInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMeterChannelInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMeterChannelInfo A, FMeterChannelInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMeterChannelInfo A, FMeterChannelInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMeterChannelInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MeterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeterValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeterValue, __InBuffer);
				}
			}
		}

		public float PeakValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PeakValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PeakValue, __InBuffer);
				}
			}
		}

		public float ClippingValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClippingValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClippingValue, __InBuffer);
				}
			}
		}

		private static uint __MeterValue = 0;

		private static uint __PeakValue = 0;

		private static uint __ClippingValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}