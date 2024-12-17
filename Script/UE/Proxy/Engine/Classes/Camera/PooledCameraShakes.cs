using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PooledCameraShakes")]
	public partial class FPooledCameraShakes : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PooledCameraShakes");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPooledCameraShakes() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPooledCameraShakes() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPooledCameraShakes A, FPooledCameraShakes B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPooledCameraShakes A, FPooledCameraShakes B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPooledCameraShakes;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UCameraShakeBase> PooledShakes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PooledShakes, __ReturnBuffer);

					return *(TArray<UCameraShakeBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PooledShakes, __InBuffer);
				}
			}
		}

		private static uint __PooledShakes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}