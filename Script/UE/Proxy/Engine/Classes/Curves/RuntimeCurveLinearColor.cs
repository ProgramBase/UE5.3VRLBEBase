using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeCurveLinearColor")]
	public partial class FRuntimeCurveLinearColor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RuntimeCurveLinearColor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRuntimeCurveLinearColor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRuntimeCurveLinearColor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRuntimeCurveLinearColor A, FRuntimeCurveLinearColor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRuntimeCurveLinearColor A, FRuntimeCurveLinearColor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRuntimeCurveLinearColor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRichCurve ColorCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorCurves, __ReturnBuffer);

					return *(FRichCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorCurves, __InBuffer);
				}
			}
		}

		public UCurveLinearColor ExternalCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalCurve, __ReturnBuffer);

					return *(UCurveLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalCurve, __InBuffer);
				}
			}
		}

		private static uint __ColorCurves = 0;

		private static uint __ExternalCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}