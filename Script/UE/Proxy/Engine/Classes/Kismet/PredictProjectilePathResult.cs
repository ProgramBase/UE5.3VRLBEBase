using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PredictProjectilePathResult")]
	public partial class FPredictProjectilePathResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PredictProjectilePathResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPredictProjectilePathResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPredictProjectilePathResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPredictProjectilePathResult A, FPredictProjectilePathResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPredictProjectilePathResult A, FPredictProjectilePathResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPredictProjectilePathResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPredictProjectilePathPointData> PathData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathData, __ReturnBuffer);

					return *(TArray<FPredictProjectilePathPointData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathData, __InBuffer);
				}
			}
		}

		public FPredictProjectilePathPointData LastTraceDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastTraceDestination, __ReturnBuffer);

					return *(FPredictProjectilePathPointData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastTraceDestination, __InBuffer);
				}
			}
		}

		public FHitResult HitResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HitResult, __ReturnBuffer);

					return *(FHitResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HitResult, __InBuffer);
				}
			}
		}

		private static uint __PathData = 0;

		private static uint __LastTraceDestination = 0;

		private static uint __HitResult = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}