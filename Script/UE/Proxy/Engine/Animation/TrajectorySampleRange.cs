using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TrajectorySampleRange")]
	public partial class FTrajectorySampleRange : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TrajectorySampleRange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTrajectorySampleRange() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTrajectorySampleRange() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTrajectorySampleRange A, FTrajectorySampleRange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTrajectorySampleRange A, FTrajectorySampleRange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTrajectorySampleRange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTrajectorySample> Samples
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Samples, __ReturnBuffer);

					return *(TArray<FTrajectorySample>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Samples, __InBuffer);
				}
			}
		}

		private static uint __Samples = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}