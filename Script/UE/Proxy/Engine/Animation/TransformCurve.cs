using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TransformCurve")]
	public partial class FTransformCurve : FAnimCurveBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TransformCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTransformCurve()
		{
		}

		public static bool operator ==(FTransformCurve A, FTransformCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTransformCurve A, FTransformCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTransformCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVectorCurve TranslationCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TranslationCurve, __ReturnBuffer);

					return *(FVectorCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TranslationCurve, __InBuffer);
				}
			}
		}

		public FVectorCurve RotationCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RotationCurve, __ReturnBuffer);

					return *(FVectorCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RotationCurve, __InBuffer);
				}
			}
		}

		public FVectorCurve ScaleCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScaleCurve, __ReturnBuffer);

					return *(FVectorCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScaleCurve, __InBuffer);
				}
			}
		}

		private static uint __TranslationCurve = 0;

		private static uint __RotationCurve = 0;

		private static uint __ScaleCurve = 0;

	}
}