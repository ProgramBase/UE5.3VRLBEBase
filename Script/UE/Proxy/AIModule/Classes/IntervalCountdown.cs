using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.IntervalCountdown")]
	public partial class FIntervalCountdown : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.IntervalCountdown");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIntervalCountdown() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIntervalCountdown() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIntervalCountdown A, FIntervalCountdown B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIntervalCountdown A, FIntervalCountdown B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIntervalCountdown;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Interval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interval, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Interval, __InBuffer);
				}
			}
		}

		private static uint __Interval = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}