using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.CompressedRichCurves")]
	public partial class FCompressedRichCurves : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.CompressedRichCurves");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCompressedRichCurves() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCompressedRichCurves() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCompressedRichCurves A, FCompressedRichCurves B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCompressedRichCurves A, FCompressedRichCurves B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCompressedRichCurves;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FCompressedRichCurve> CompressedRichCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompressedRichCurves, __ReturnBuffer);

					return *(TArray<FCompressedRichCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompressedRichCurves, __InBuffer);
				}
			}
		}

		private static uint __CompressedRichCurves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}