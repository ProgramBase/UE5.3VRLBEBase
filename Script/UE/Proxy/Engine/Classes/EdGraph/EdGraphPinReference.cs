using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EdGraphPinReference")]
	public partial class FEdGraphPinReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EdGraphPinReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphPinReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEdGraphPinReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEdGraphPinReference A, FEdGraphPinReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphPinReference A, FEdGraphPinReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphPinReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UEdGraphNode> OwningNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwningNode, __ReturnBuffer);

					return *(TWeakObjectPtr<UEdGraphNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwningNode, __InBuffer);
				}
			}
		}

		public FGuid PinId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PinId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PinId, __InBuffer);
				}
			}
		}

		private static uint __OwningNode = 0;

		private static uint __PinId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}