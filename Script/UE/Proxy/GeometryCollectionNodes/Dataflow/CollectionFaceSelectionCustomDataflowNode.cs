using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionFaceSelectionCustomDataflowNode")]
	public partial class FCollectionFaceSelectionCustomDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionFaceSelectionCustomDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionFaceSelectionCustomDataflowNode()
		{
		}

		public static bool operator ==(FCollectionFaceSelectionCustomDataflowNode A, FCollectionFaceSelectionCustomDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionFaceSelectionCustomDataflowNode A, FCollectionFaceSelectionCustomDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionFaceSelectionCustomDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FManagedArrayCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FManagedArrayCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		public FString FaceIndicies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FaceIndicies, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FaceIndicies, __InBuffer);
				}
			}
		}

		public FDataflowFaceSelection FaceSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __ReturnBuffer);

					return *(FDataflowFaceSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __FaceIndicies = 0;

		private static uint __FaceSelection = 0;

	}
}