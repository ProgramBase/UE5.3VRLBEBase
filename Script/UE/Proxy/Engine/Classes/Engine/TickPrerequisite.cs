using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TickPrerequisite")]
	public partial class FTickPrerequisite : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TickPrerequisite");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTickPrerequisite() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTickPrerequisite() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTickPrerequisite A, FTickPrerequisite B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTickPrerequisite A, FTickPrerequisite B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTickPrerequisite;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}