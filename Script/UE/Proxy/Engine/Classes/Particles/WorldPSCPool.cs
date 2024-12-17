using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPSCPool")]
	public partial class FWorldPSCPool : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPSCPool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPSCPool() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPSCPool() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPSCPool A, FWorldPSCPool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPSCPool A, FWorldPSCPool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPSCPool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<UParticleSystem, FPSCPool> WorldParticleSystemPools
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldParticleSystemPools, __ReturnBuffer);

					return *(TMap<UParticleSystem, FPSCPool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldParticleSystemPools, __InBuffer);
				}
			}
		}

		private static uint __WorldParticleSystemPools = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}