using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.CurveEditorBakeFilterRange")]
	public partial class FCurveEditorBakeFilterRange : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CurveEditor.CurveEditorBakeFilterRange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveEditorBakeFilterRange() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCurveEditorBakeFilterRange() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCurveEditorBakeFilterRange A, FCurveEditorBakeFilterRange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveEditorBakeFilterRange A, FCurveEditorBakeFilterRange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveEditorBakeFilterRange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumber Min
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Min, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Min, __InBuffer);
				}
			}
		}

		public FFrameNumber Max
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Max, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Max, __InBuffer);
				}
			}
		}

		private static uint __Min = 0;

		private static uint __Max = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}