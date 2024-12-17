using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NonBlendableQuaternionAnimationAttribute")]
	public partial class FNonBlendableQuaternionAnimationAttribute : FQuaternionAnimationAttribute, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NonBlendableQuaternionAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNonBlendableQuaternionAnimationAttribute()
		{
		}

		public static bool operator ==(FNonBlendableQuaternionAnimationAttribute A, FNonBlendableQuaternionAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNonBlendableQuaternionAnimationAttribute A, FNonBlendableQuaternionAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNonBlendableQuaternionAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}