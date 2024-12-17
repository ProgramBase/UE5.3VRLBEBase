using Script.CoreUObject;
using Script.Library;

namespace Script.PBIK
{
	[PathName("/Script/PBIK.PBIKSolver")]
	public partial class FPBIKSolver : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PBIK.PBIKSolver");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPBIKSolver() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPBIKSolver() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPBIKSolver A, FPBIKSolver B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPBIKSolver A, FPBIKSolver B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPBIKSolver;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}