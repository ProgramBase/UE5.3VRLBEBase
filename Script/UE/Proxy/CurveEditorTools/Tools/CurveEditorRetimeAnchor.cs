using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditorTools
{
	[PathName("/Script/CurveEditorTools.CurveEditorRetimeAnchor")]
	public partial class FCurveEditorRetimeAnchor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CurveEditorTools.CurveEditorRetimeAnchor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveEditorRetimeAnchor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCurveEditorRetimeAnchor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCurveEditorRetimeAnchor A, FCurveEditorRetimeAnchor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveEditorRetimeAnchor A, FCurveEditorRetimeAnchor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveEditorRetimeAnchor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double ValueInSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValueInSeconds, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValueInSeconds, __InBuffer);
				}
			}
		}

		public bool bIsSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsSelected, __InBuffer);
				}
			}
		}

		private static uint __ValueInSeconds = 0;

		private static uint __bIsSelected = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}