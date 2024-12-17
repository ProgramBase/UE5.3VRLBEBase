using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BPInterfaceDescription")]
	public partial class FBPInterfaceDescription : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BPInterfaceDescription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBPInterfaceDescription() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBPInterfaceDescription() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBPInterfaceDescription A, FBPInterfaceDescription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBPInterfaceDescription A, FBPInterfaceDescription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBPInterfaceDescription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UInterface> Interface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __ReturnBuffer);

					return *(TSubclassOf<UInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __InBuffer);
				}
			}
		}

		public TArray<UEdGraph> Graphs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Graphs, __ReturnBuffer);

					return *(TArray<UEdGraph>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Graphs, __InBuffer);
				}
			}
		}

		private static uint __Interface = 0;

		private static uint __Graphs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}