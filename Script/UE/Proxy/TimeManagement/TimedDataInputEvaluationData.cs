using Script.CoreUObject;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.TimedDataInputEvaluationData")]
	public partial class FTimedDataInputEvaluationData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TimeManagement.TimedDataInputEvaluationData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimedDataInputEvaluationData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimedDataInputEvaluationData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimedDataInputEvaluationData A, FTimedDataInputEvaluationData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimedDataInputEvaluationData A, FTimedDataInputEvaluationData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimedDataInputEvaluationData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float DistanceToNewestSampleSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DistanceToNewestSampleSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DistanceToNewestSampleSeconds, __InBuffer);
				}
			}
		}

		public float DistanceToOldestSampleSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DistanceToOldestSampleSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DistanceToOldestSampleSeconds, __InBuffer);
				}
			}
		}

		private static uint __DistanceToNewestSampleSeconds = 0;

		private static uint __DistanceToOldestSampleSeconds = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}