using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InertializationPoseDiff")]
	public partial class FInertializationPoseDiff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InertializationPoseDiff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInertializationPoseDiff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInertializationPoseDiff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInertializationPoseDiff A, FInertializationPoseDiff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInertializationPoseDiff A, FInertializationPoseDiff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInertializationPoseDiff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}