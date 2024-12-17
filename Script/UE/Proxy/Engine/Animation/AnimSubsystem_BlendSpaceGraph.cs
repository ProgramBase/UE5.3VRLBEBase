using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystem_BlendSpaceGraph")]
	public partial class FAnimSubsystem_BlendSpaceGraph : FAnimSubsystem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystem_BlendSpaceGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystem_BlendSpaceGraph()
		{
		}

		public static bool operator ==(FAnimSubsystem_BlendSpaceGraph A, FAnimSubsystem_BlendSpaceGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystem_BlendSpaceGraph A, FAnimSubsystem_BlendSpaceGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystem_BlendSpaceGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UBlendSpace> BlendSpaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendSpaces, __ReturnBuffer);

					return *(TArray<UBlendSpace>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendSpaces, __InBuffer);
				}
			}
		}

		private static uint __BlendSpaces = 0;

	}
}