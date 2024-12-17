using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FloatInterval")]
	public partial class FFloatInterval : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FloatInterval");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatInterval() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFloatInterval() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFloatInterval A, FFloatInterval B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatInterval A, FFloatInterval B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatInterval;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Min
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Min, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Min, __InBuffer);
				}
			}
		}

		public float Max
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Max, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Max, __InBuffer);
				}
			}
		}

		private static uint __Min = 0;

		private static uint __Max = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}