using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ConstraintInstanceBase")]
	public partial class FConstraintInstanceBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ConstraintInstanceBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintInstanceBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstraintInstanceBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstraintInstanceBase A, FConstraintInstanceBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintInstanceBase A, FConstraintInstanceBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintInstanceBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}