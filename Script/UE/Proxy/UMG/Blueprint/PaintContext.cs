using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.PaintContext")]
	public partial class FPaintContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.PaintContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPaintContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPaintContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPaintContext A, FPaintContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPaintContext A, FPaintContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPaintContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}