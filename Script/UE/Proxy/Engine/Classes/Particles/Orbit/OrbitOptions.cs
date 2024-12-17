using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.OrbitOptions")]
	public partial class FOrbitOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.OrbitOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FOrbitOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FOrbitOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FOrbitOptions A, FOrbitOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FOrbitOptions A, FOrbitOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FOrbitOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bProcessDuringSpawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bProcessDuringSpawn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bProcessDuringSpawn, __InBuffer);
				}
			}
		}

		public bool bProcessDuringUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bProcessDuringUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bProcessDuringUpdate, __InBuffer);
				}
			}
		}

		public bool bUseEmitterTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseEmitterTime, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseEmitterTime, __InBuffer);
				}
			}
		}

		private static uint __bProcessDuringSpawn = 0;

		private static uint __bProcessDuringUpdate = 0;

		private static uint __bUseEmitterTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}