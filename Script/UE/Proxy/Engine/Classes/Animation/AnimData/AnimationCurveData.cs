using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationCurveData")]
	public partial class FAnimationCurveData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimationCurveData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationCurveData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationCurveData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationCurveData A, FAnimationCurveData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationCurveData A, FAnimationCurveData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationCurveData;

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

		private static uint __TransformCurves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}