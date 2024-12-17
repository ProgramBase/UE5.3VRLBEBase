using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.NodeHierarchyData")]
	public partial class FNodeHierarchyData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.NodeHierarchyData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNodeHierarchyData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNodeHierarchyData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNodeHierarchyData A, FNodeHierarchyData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNodeHierarchyData A, FNodeHierarchyData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNodeHierarchyData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNodeObject> Nodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __ReturnBuffer);

					return *(TArray<FNodeObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __InBuffer);
				}
			}
		}

		public TArray<FTransform> Transforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __InBuffer);
				}
			}
		}

		public TMap<FName, int> NodeNameToIndexMapping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeNameToIndexMapping, __ReturnBuffer);

					return *(TMap<FName, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeNameToIndexMapping, __InBuffer);
				}
			}
		}

		private static uint __Nodes = 0;

		private static uint __Transforms = 0;

		private static uint __NodeNameToIndexMapping = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}