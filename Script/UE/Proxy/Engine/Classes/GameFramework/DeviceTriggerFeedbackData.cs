using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DeviceTriggerFeedbackData")]
	public partial class FDeviceTriggerFeedbackData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DeviceTriggerFeedbackData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDeviceTriggerFeedbackData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDeviceTriggerFeedbackData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDeviceTriggerFeedbackData A, FDeviceTriggerFeedbackData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDeviceTriggerFeedbackData A, FDeviceTriggerFeedbackData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDeviceTriggerFeedbackData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCurveFloat FeedbackPositionCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FeedbackPositionCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FeedbackPositionCurve, __InBuffer);
				}
			}
		}

		public UCurveFloat FeedbackStrenghCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FeedbackStrenghCurve, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FeedbackStrenghCurve, __InBuffer);
				}
			}
		}

		private static uint __FeedbackPositionCurve = 0;

		private static uint __FeedbackStrenghCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}