using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BandwidthTestGenerator")]
	public partial class FBandwidthTestGenerator : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BandwidthTestGenerator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBandwidthTestGenerator() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBandwidthTestGenerator() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBandwidthTestGenerator A, FBandwidthTestGenerator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBandwidthTestGenerator A, FBandwidthTestGenerator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBandwidthTestGenerator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBandwidthTestItem> ReplicatedBuffers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplicatedBuffers, __ReturnBuffer);

					return *(TArray<FBandwidthTestItem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplicatedBuffers, __InBuffer);
				}
			}
		}

		private static uint __ReplicatedBuffers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}