using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RawCurveTracks")]
	public partial class FRawCurveTracks : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RawCurveTracks");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRawCurveTracks() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRawCurveTracks() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRawCurveTracks A, FRawCurveTracks B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRawCurveTracks A, FRawCurveTracks B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRawCurveTracks;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FFloatCurve> FloatCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurves, __ReturnBuffer);

					return *(TArray<FFloatCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatCurves, __InBuffer);
				}
			}
		}

		public TArray<FVectorCurve> VectorCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VectorCurves, __ReturnBuffer);

					return *(TArray<FVectorCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VectorCurves, __InBuffer);
				}
			}
		}

		public TArray<FTransformCurve> TransformCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformCurves, __ReturnBuffer);

					return *(TArray<FTransformCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformCurves, __InBuffer);
				}
			}
		}

		private static uint __FloatCurves = 0;

		private static uint __VectorCurves = 0;

		private static uint __TransformCurves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}