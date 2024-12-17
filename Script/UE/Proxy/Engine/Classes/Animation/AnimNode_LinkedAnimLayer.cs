using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_LinkedAnimLayer")]
	public partial class FAnimNode_LinkedAnimLayer : FAnimNode_LinkedAnimGraph, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_LinkedAnimLayer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_LinkedAnimLayer()
		{
		}

		public static bool operator ==(FAnimNode_LinkedAnimLayer A, FAnimNode_LinkedAnimLayer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_LinkedAnimLayer A, FAnimNode_LinkedAnimLayer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_LinkedAnimLayer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UAnimLayerInterface> Interface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __ReturnBuffer);

					return *(TSubclassOf<UAnimLayerInterface>*)__ReturnBuffer;
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

		public FName Layer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Layer, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Layer, __InBuffer);
				}
			}
		}

		private static uint __Interface = 0;

		private static uint __Layer = 0;

	}
}