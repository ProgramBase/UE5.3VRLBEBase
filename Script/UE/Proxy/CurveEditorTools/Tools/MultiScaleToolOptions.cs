using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.MultiScaleToolOptions")]
	public partial class FMultiScaleToolOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CurveEditorTools.MultiScaleToolOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMultiScaleToolOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMultiScaleToolOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMultiScaleToolOptions A, FMultiScaleToolOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMultiScaleToolOptions A, FMultiScaleToolOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMultiScaleToolOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float XScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __XScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __XScale, __InBuffer);
				}
			}
		}

		public float YScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __YScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __YScale, __InBuffer);
				}
			}
		}

		public EMultiScalePivotType PivotType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PivotType, __ReturnBuffer);

					return *(EMultiScalePivotType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PivotType, __InBuffer);
				}
			}
		}

		private static uint __XScale = 0;

		private static uint __YScale = 0;

		private static uint __PivotType = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}