using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.CCDIKChainLink")]
	public partial class FCCDIKChainLink : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.CCDIKChainLink");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCCDIKChainLink() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCCDIKChainLink() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCCDIKChainLink A, FCCDIKChainLink B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCCDIKChainLink A, FCCDIKChainLink B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCCDIKChainLink;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}