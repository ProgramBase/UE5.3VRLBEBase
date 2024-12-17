using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystem_Tag")]
	public partial class FAnimSubsystem_Tag : FAnimSubsystem, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystem_Tag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystem_Tag()
		{
		}

		public static bool operator ==(FAnimSubsystem_Tag A, FAnimSubsystem_Tag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystem_Tag A, FAnimSubsystem_Tag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystem_Tag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FName, int> NodeIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeIndices, __ReturnBuffer);

					return *(TMap<FName, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeIndices, __InBuffer);
				}
			}
		}

		private static uint __NodeIndices = 0;

	}
}