using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NonBlendableIntegerAnimationAttribute")]
	public partial class FNonBlendableIntegerAnimationAttribute : FIntegerAnimationAttribute, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NonBlendableIntegerAnimationAttribute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNonBlendableIntegerAnimationAttribute()
		{
		}

		public static bool operator ==(FNonBlendableIntegerAnimationAttribute A, FNonBlendableIntegerAnimationAttribute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNonBlendableIntegerAnimationAttribute A, FNonBlendableIntegerAnimationAttribute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNonBlendableIntegerAnimationAttribute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}