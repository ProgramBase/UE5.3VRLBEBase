using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.FABRIKChainLink")]
	public partial class FFABRIKChainLink : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.FABRIKChainLink");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFABRIKChainLink() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFABRIKChainLink() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFABRIKChainLink A, FFABRIKChainLink B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFABRIKChainLink A, FFABRIKChainLink B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFABRIKChainLink;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}