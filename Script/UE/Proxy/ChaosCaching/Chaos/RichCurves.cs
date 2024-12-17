using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.RichCurves")]
	public partial class FRichCurves : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.RichCurves");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRichCurves() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRichCurves() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRichCurves A, FRichCurves B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRichCurves A, FRichCurves B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRichCurves;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRichCurve> RichCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RichCurves, __ReturnBuffer);

					return *(TArray<FRichCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RichCurves, __InBuffer);
				}
			}
		}

		private static uint __RichCurves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}