using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InertializationBoneDiff")]
	public partial class FInertializationBoneDiff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InertializationBoneDiff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInertializationBoneDiff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInertializationBoneDiff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInertializationBoneDiff A, FInertializationBoneDiff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInertializationBoneDiff A, FInertializationBoneDiff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInertializationBoneDiff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}